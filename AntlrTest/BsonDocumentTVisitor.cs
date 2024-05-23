using MongoDB.Bson;

namespace AntlrTest
{
    public class BsonDocumentTVisitor : TBaseVisitor<BsonDocument>
    {
        public override BsonDocument VisitParse(TParser.ParseContext context)
        {
            return context.expr() == null ? new BsonDocument() : Visit(context.expr());
        }

        public override BsonDocument VisitLogicalOperation(TParser.LogicalOperationContext context)
        {
            var left = Visit(context.expr(0));
            var right = Visit(context.expr(1));
            var logop = $"${context.LOGOP().GetText()}";
            var bsonArray = new BsonArray { left, right };
            return new BsonDocument(logop, bsonArray);
        }

        public override BsonDocument VisitParenthesizedExpression(TParser.ParenthesizedExpressionContext context)
        {
            return Visit(context.expr());
        }

        public override BsonDocument VisitComparisonExpression(TParser.ComparisonExpressionContext context)
        {
            return VisitComparison(context.comparison());
        }

        public override BsonDocument VisitComparison(TParser.ComparisonContext context)
        {
            string prop = context.IDENTIFIER().GetText();
            string op = $"${context.OP().GetText()}";
            string value = context.value().GetText();

            if (int.TryParse(value, out int intValue))
            {
                return new BsonDocument(prop, new BsonDocument(op, intValue));
            }

            if (bool.TryParse(value, out bool boolValue))
            {
                return new BsonDocument(prop, new BsonDocument(op, boolValue));
            }
            
            if (DateTime.TryParse(value, out DateTime dateTimeValue))
            {
                return new BsonDocument(prop, new BsonDocument(op, dateTimeValue));
            }

            // If the value is a string, it will be enclosed in double quotes
            value = value.Trim('"');

            return new BsonDocument(prop, new BsonDocument(op, value));
        }
    }
}