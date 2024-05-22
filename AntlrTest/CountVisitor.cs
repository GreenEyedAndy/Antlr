namespace AntlrTest;

public class CountVisitor : cookieBaseVisitor<int>
{
    public override int VisitAv_pair(cookieParser.Av_pairContext context)
    {
        if (context.value() is not null)
        {
            return VisitAttr(context.attr()) + VisitValue(context.value());
        }
        else
        {
            return VisitAttr(context.attr());
        }
    }

    public override int VisitAttr(cookieParser.AttrContext context)
    {
        return 1;
    }

    public override int VisitValue(cookieParser.ValueContext context)
    {
        return 1;
    }

    protected override int AggregateResult(int aggregate, int nextResult)
    {
        return aggregate + nextResult;
    }

    protected override int DefaultResult => 0;
}