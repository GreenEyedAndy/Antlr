using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace AntlrTest;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string input = """
                       f(x,y) {
                           a = 3+4;
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
        Console.WriteLine(output);
    }
}