using Antlr4.Runtime.Misc;

namespace AntlrTest;

public class AdditionVisitor : AdditionParserBaseVisitor<int>
{
    public override int VisitEquation([NotNull] AdditionParser.EquationContext context)
    {
        int left = int.Parse(context.INT()[0].GetText());
        int right = int.Parse(context.INT()[1].GetText());
        return left + right;
    }
}