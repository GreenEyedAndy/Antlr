namespace AntlrTest;

public class Calculator : ExprParserBaseVisitor<object>
{
    public override object VisitProgram(ExprParser.ProgramContext context)
    {
        Console.WriteLine(context.GetText() + ' ');
        return context.GetText();
    }

    public override object VisitStat(ExprParser.StatContext context)
    {
        //Console.WriteLine(context.GetText() + ' ');
        return context.GetText();
    }

    public override object VisitDef(ExprParser.DefContext context)
    {
        Console.WriteLine(context.GetText() + ' ');
        return context.GetText();
    }

    public override object VisitExpr(ExprParser.ExprContext context)
    {
        //Console.WriteLine(context.GetText() + ' ');
        return context.GetText();
    }

    public override object VisitFunc(ExprParser.FuncContext context)
    {
        //Console.WriteLine(context.GetText() + ' ');
        return context.GetText();
    }
}