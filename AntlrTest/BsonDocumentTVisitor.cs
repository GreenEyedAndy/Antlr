using MongoDB.Bson;

namespace AntlrTest;

public class BsonDocumentTVisitor : TBaseVisitor<BsonDocument>
{
    public override BsonDocument VisitLine(TParser.LineContext context)
    {
        return context.elems() == null ? new BsonDocument() : VisitElems(context.elems());
    }

    public override BsonDocument VisitElems(TParser.ElemsContext context)
    {
        if (context.expr().Length == 1)
        {
            return VisitExpr(context.expr()[0]);
        }
    
        // Initialisiere das Dokument mit dem Ergebnis des ersten Ausdrucks
        var document = VisitExpr(context.expr()[0]);
    
        for (int i = 1; i < context.expr().Length; i++)
        {
            var bsonDocument = VisitExpr(context.expr()[i]);
            var logop = $"${context.LOGOP(i - 1).GetText()}";
            var bsonArray = new BsonArray { document, bsonDocument };
            document = new BsonDocument(logop, bsonArray);
        }
    
        return document;
    }

    public override BsonDocument VisitExpr(TParser.ExprContext context)
    {
        string prop = context.PROP().GetText();
        string op = $"${context.OP()}";
        string value = context.VALUE().GetText();

        var bsonArray = new BsonArray();
        
        if (int.TryParse(value, out int intValue))
        {
            bsonArray.Add(new BsonDocument(prop, new BsonDocument(op, intValue)));
            bsonArray.Add(new BsonDocument(prop, new BsonDocument(op, value)));
            return new ("$or", bsonArray); 
        }
        if (DateTime.TryParse(value, out DateTime dateTimeValue))
        {
            return new BsonDocument(prop, new BsonDocument(op, dateTimeValue));
        }
        if (bool.TryParse(value, out bool boolValue))
        {
            return new BsonDocument(prop, new BsonDocument(op, boolValue));
        }
        
        // alles Andere
        return new BsonDocument(prop, new BsonDocument(op, value.Replace("\"", "")));
    }
}