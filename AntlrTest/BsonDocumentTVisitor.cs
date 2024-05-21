using MongoDB.Bson;

namespace AntlrTest;

public class BsonDocumentTVisitor : TBaseVisitor<BsonDocument>
{
    private readonly BsonDocument filterDocument = new();
    private readonly BsonArray filters = new();

    public override BsonDocument VisitLine(TParser.LineContext context)
    {
        return context.elems() == null ? new BsonDocument() : VisitElems(context.elems());
    }

    public override BsonDocument VisitElems(TParser.ElemsContext context)
    {
        BsonDocument doc = VisitExpr(context.expr()[0]);
        return doc;
    }

    public override BsonDocument VisitExpr(TParser.ExprContext context)
    {
        string op = $"${context.OP()}";
        BsonDocument doc = new BsonDocument(context.PROP(), new BsonDocument(op, context.VALUE()));
        return 
    }
}