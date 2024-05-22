using MongoDB.Bson;

namespace UrlFilterToBsonDocument;

public class UrlFilterVisitor : UrlFilterBaseVisitor<BsonDocument>
{
    public override BsonDocument VisitParse(UrlFilterParser.ParseContext context)
    {
        return context.expr() == null ? new BsonDocument() : Visit(context.expr());
    }

    public override BsonDocument VisitLogicalOperation(UrlFilterParser.LogicalOperationContext context)
    {
        var left = Visit(context.expr(0));
        var right = Visit(context.expr(1));
        var logop = $"${context.LOGOP().GetText()}";
        var bsonArray = new BsonArray { left, right };
        return new BsonDocument(logop, bsonArray);
    }

    public override BsonDocument VisitParenthesizedExpression(UrlFilterParser.ParenthesizedExpressionContext context)
    {
        return Visit(context.expr());
    }

    public override BsonDocument VisitComparisonExpression(UrlFilterParser.ComparisonExpressionContext context)
    {
        return VisitComparison(context.comparison());
    }

    public override BsonDocument VisitComparison(UrlFilterParser.ComparisonContext context)
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

        // If the value is a string, it will be enclosed in double quotes
        value = value.Trim('"');

        return new BsonDocument(prop, new BsonDocument(op, value));
    }
}
