//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:/Source/Antlr/UrlFilterToBsonDocument/UrlFilter.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="UrlFilterParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface IUrlFilterListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="UrlFilterParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParse([NotNull] UrlFilterParser.ParseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="UrlFilterParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParse([NotNull] UrlFilterParser.ParseContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesizedExpression</c>
	/// labeled alternative in <see cref="UrlFilterParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesizedExpression([NotNull] UrlFilterParser.ParenthesizedExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesizedExpression</c>
	/// labeled alternative in <see cref="UrlFilterParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesizedExpression([NotNull] UrlFilterParser.ParenthesizedExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalOperation</c>
	/// labeled alternative in <see cref="UrlFilterParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalOperation([NotNull] UrlFilterParser.LogicalOperationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalOperation</c>
	/// labeled alternative in <see cref="UrlFilterParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalOperation([NotNull] UrlFilterParser.LogicalOperationContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ComparisonExpression</c>
	/// labeled alternative in <see cref="UrlFilterParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparisonExpression([NotNull] UrlFilterParser.ComparisonExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ComparisonExpression</c>
	/// labeled alternative in <see cref="UrlFilterParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparisonExpression([NotNull] UrlFilterParser.ComparisonExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="UrlFilterParser.comparison"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparison([NotNull] UrlFilterParser.ComparisonContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="UrlFilterParser.comparison"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparison([NotNull] UrlFilterParser.ComparisonContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="UrlFilterParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValue([NotNull] UrlFilterParser.ValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="UrlFilterParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValue([NotNull] UrlFilterParser.ValueContext context);
}