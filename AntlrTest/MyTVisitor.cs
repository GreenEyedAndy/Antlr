using Antlr4.Runtime.Tree;

namespace AntlrTest;

public class MyTVisitor : TBaseVisitor<string>
{
    private string result = string.Empty;

    public override string VisitLine(TParser.LineContext context)
    {
        return context.elems() == null ? "" : "[ " + VisitElems(context.elems()) + " ]";
    }

    public override string VisitElems(TParser.ElemsContext context)
    {
        string str = VisitExpr(context.expr()[0]);
        for (int i = 1; i < context.expr().Length; i++)
        {
            str += $" {context.LOGOP().GetValue(i-1)} " + VisitExpr(context.expr()[i]);
        }
        return str;
    }

    public override string VisitExpr(TParser.ExprContext context)
    {
        // if (context.STRING() is not null)
        // {
        //     return $"{context.PROP()} {context.OP()} {context.STRING()}";
        // }
        // if (context.POSITIVE() is not null)
        // {
        //     return $"{context.PROP()} {context.OP()} {context.POSITIVE()}";
        // }
        // if (context.NEGATIVE() is not null)
        // {
        //     return $"{context.PROP()} {context.OP()} {context.NEGATIVE()}";
        // }
        // if (context.BOOL() is not null)
        // {
        //     return $"{context.PROP()} {context.OP()} {context.BOOL()}";
        // }
        return $"{context.PROP()} {context.OP()} {context.VALUE()}";
    }
}