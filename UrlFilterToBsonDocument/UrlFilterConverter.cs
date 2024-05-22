using Antlr4.Runtime;
using MongoDB.Bson;

namespace UrlFilterToBsonDocument;

public static class UrlFilterConverter
{
    public static BsonDocument ConvertToBson(string filterString)
    {
        ITokenSource lexer = new UrlFilterLexer(CharStreams.fromString(filterString));
        UrlFilterParser parser = new UrlFilterParser(new CommonTokenStream(lexer));
        return new UrlFilterVisitor().Visit(parser.parse());   
    }
}