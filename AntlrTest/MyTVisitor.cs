using Antlr4.Runtime.Tree;

namespace AntlrTest;

public class MyTVisitor : TBaseVisitor<string>
{
    private string result = string.Empty;
    public override string VisitLine(TParser.LineContext context)
    {
        return result + Visit(context.expr(0));
    }

    public override string VisitExpr(TParser.ExprContext context)
    {
        var prop = context.PROP();
        var op = context.OP();
        var value = context.VALUE();
        var logop = context.LOGOP();

        return logop == null
            ? $"{prop} {op} {value}"
            : HandleGroup(context.expr()); 
        
        if (logop is not null)
        {
            var logicOperator = logop.GetText();
            switch (logicOperator)
            {
                case "and":
                    result += "and " + Visit(context.expr());
                    break;
                case "or":
                    result += "or " + Visit(context.expr());
                    break;
                case "xor":
                    result += "xor " + Visit(context.expr());
                    break;
            }
        }
            
        return result += $"{prop} {op} {value}";
    }

    private string HandleGroup(TParser.ExprContext expr)
    {
        result += expr.children.OfType<TParser.ExprContext>().Select(HandleGroup);
        return string.Join("->", expr.children.Where(c => c is ITerminalNode).Select(c => c.GetText())) + result;
    }
}