using System.Runtime.CompilerServices;

namespace AntlrTest;

public class TalkingListener : cookieBaseListener
{
    public override void EnterCookie(cookieParser.CookieContext context)
    {
        Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()} {context.GetText()}");
    }

    public override void ExitCookie(cookieParser.CookieContext context)
    {
        Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()} {context.GetText()}");
    }

    public override void EnterName(cookieParser.NameContext context)
    {
        Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()} {context.GetText()}");
    }

    public override void ExitName(cookieParser.NameContext context)
    {
        Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()} {context.GetText()}");
    }

    public override void EnterAv_pairs(cookieParser.Av_pairsContext context)
    {
        Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()} {context.GetText()}");
    }

    public override void ExitAv_pairs(cookieParser.Av_pairsContext context)
    {
        Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()} {context.GetText()}");
    }

    public override void EnterAv_pair(cookieParser.Av_pairContext context)
    {
        Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()} {context.GetText()}");
    }

    public override void ExitAv_pair(cookieParser.Av_pairContext context)
    {
        Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()} {context.GetText()}");
    }

    public override void EnterAttr(cookieParser.AttrContext context)
    {
        Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()} {context.GetText()}");
    }

    public override void ExitAttr(cookieParser.AttrContext context)
    {
        Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()} {context.GetText()}");
    }

    public override void EnterValue(cookieParser.ValueContext context)
    {
        Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()} {context.GetText()}");
    }

    public override void ExitValue(cookieParser.ValueContext context)
    {
        Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()} {context.GetText()}");
    }

    public override void EnterWord(cookieParser.WordContext context)
    {
        Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()} {context.GetText()}");
    }

    public override void ExitWord(cookieParser.WordContext context)
    {
        Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()} {context.GetText()}");
    }

    public override void EnterToken(cookieParser.TokenContext context)
    {
        Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()} {context.GetText()}");
    }

    public override void ExitToken(cookieParser.TokenContext context)
    {
        Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()} {context.GetText()}");
    }

    public override void EnterQuoted_string(cookieParser.Quoted_stringContext context)
    {
        Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()} {context.GetText()}");
    }

    public override void ExitQuoted_string(cookieParser.Quoted_stringContext context)
    {
        Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()} {context.GetText()}");
    }
}