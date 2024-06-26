﻿using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace AntlrTest;

class Program
{
    static void Main(string[] args)
    {
        CallExpr();
        CallAddition();
        CallT();
        CallCsv();
        CallCookie();
        //Console.WriteLine(output);
    }

    private static void CallCookie()
    {
        string input = "sessionToken=abc123; Expires=Wed, 09 Jun 2021 10:18:14 GMT";
        ITokenSource lexer = new cookieLexer(CharStreams.fromString(input));
        cookieParser parser = new cookieParser(new CommonTokenStream(lexer));
        cookieParser.CookieContext cookieContext = parser.cookie();
        TalkingListener listener = new TalkingListener();
        //ParseTreeWalker.Default.Walk(listener, cookieContext);

        CountVisitor visitor = new CountVisitor();
        Console.WriteLine($"Number of nodes: {visitor.VisitCookie(cookieContext)}");
    }

    private static void CallCsv()
    {
        string input = "[2.5,65,7.3g]";
        ITokenSource lexer = new csvLexer(CharStreams.fromString(input));
        csvParser parser = new csvParser(new CommonTokenStream(lexer));
        var str = new PrettyVisitor().Visit(parser.list());
        Console.WriteLine(str);
    }

    private static void CallT()
    {
        string input = """
                       name eq Andy or (name eq "Igor" and age gte 0.46 and flag eq true) or lastModified lt 2023-07-19T14:35:31.347Z
                       """;
        // string input = """
        //                name lt 2023-07-19T14:35:31.347Z
        //                """;
        // string input = """
        //                name eq 123
        //                """;
        // string input = """
        //                name eq "Andy" or name eq "Igor" and flag eq true and test eq true
        //                """;
        ITokenSource lexer = new TLexer(CharStreams.fromString(input));
        TParser parser = new TParser(new CommonTokenStream(lexer));
        //var str = new MyTVisitor().Visit(parser.line());
        var str = new BsonDocumentTVisitor().Visit(parser.parse());
        Console.WriteLine(str.ToString());
    }

    private static void CallAddition()
    {
        string input = "4 + 5";
        ITokenSource lexer = new AdditionLexer(CharStreams.fromString(input));
        AdditionParser parser = new AdditionParser(new CommonTokenStream(lexer));
        IParseTree tree = parser.equation();
        AdditionVisitor visitor = new AdditionVisitor();
        var output = visitor.Visit(tree);
        Console.WriteLine($"{input} = {output}");
    }

    private static void CallExpr()
    {
        string input = """
                       f(x,y) {
                           a = 3;
                           x and y;
                       }
                       """;
        ICharStream stream = CharStreams.fromString(input);
        ITokenSource lexer = new ExprLexer(stream);
        ITokenStream tokens = new CommonTokenStream(lexer);
        ExprParser parser = new ExprParser(tokens);
        parser.BuildParseTree = true;
        IParseTree tree = parser.program();
        Calculator calculator = new Calculator();
        var output = calculator.Visit(tree);
    }
}