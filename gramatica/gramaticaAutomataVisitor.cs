//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/enmanuelreynoso/Documents/repos/lenguajeAutomatas/gramatica/gramaticaAutomata.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="gramaticaAutomataParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public interface IgramaticaAutomataVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="gramaticaAutomataParser.automata"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAutomata([NotNull] gramaticaAutomataParser.AutomataContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="gramaticaAutomataParser.tipo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTipo([NotNull] gramaticaAutomataParser.TipoContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="gramaticaAutomataParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInicio([NotNull] gramaticaAutomataParser.InicioContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="gramaticaAutomataParser.aceptacion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAceptacion([NotNull] gramaticaAutomataParser.AceptacionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="gramaticaAutomataParser.transiciones"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTransiciones([NotNull] gramaticaAutomataParser.TransicionesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="gramaticaAutomataParser.transicion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTransicion([NotNull] gramaticaAutomataParser.TransicionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="gramaticaAutomataParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInput([NotNull] gramaticaAutomataParser.InputContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="gramaticaAutomataParser.estados"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEstados([NotNull] gramaticaAutomataParser.EstadosContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="gramaticaAutomataParser.estado"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEstado([NotNull] gramaticaAutomataParser.EstadoContext context);
}