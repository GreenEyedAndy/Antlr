using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace AntlrTest;

class Program
{
    static void Main(string[] args)
    {
        CallExpr();
        CallAddition();
        //Console.WriteLine(output);
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
        IParseTree tree = parser.program();
        Calculator calculator = new Calculator();
        var output = calculator.Visit(tree);
    }
}