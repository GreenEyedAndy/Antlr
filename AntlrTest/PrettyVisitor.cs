namespace AntlrTest;

public class PrettyVisitor : csvBaseVisitor<string>
{
    public override string VisitList(csvParser.ListContext context)
    {
        return context.elems() == null ? "" : "[ " + VisitElems(context.elems()) + " ]";
    }

    public override string VisitElems(csvParser.ElemsContext context)
    {
        string str = VisitElem(context.elem()[0]);
        for (int i = 1; i < context.elem().Length; i++)
        {
            str += ", " + VisitElem(context.elem()[i]);
        }
        return str;
    }

    public override string VisitElem(csvParser.ElemContext context)
    {
        return context.GetText();
    }
}