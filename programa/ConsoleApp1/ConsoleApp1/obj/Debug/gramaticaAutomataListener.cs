//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Kerlyn\source\repos\ConsoleApp1\ConsoleApp1\gramaticaAutomata.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace ConsoleApp1 {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="gramaticaAutomataParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IgramaticaAutomataListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="gramaticaAutomataParser.automata"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAutomata([NotNull] gramaticaAutomataParser.AutomataContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="gramaticaAutomataParser.automata"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAutomata([NotNull] gramaticaAutomataParser.AutomataContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="gramaticaAutomataParser.tipo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTipo([NotNull] gramaticaAutomataParser.TipoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="gramaticaAutomataParser.tipo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTipo([NotNull] gramaticaAutomataParser.TipoContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="gramaticaAutomataParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInicio([NotNull] gramaticaAutomataParser.InicioContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="gramaticaAutomataParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInicio([NotNull] gramaticaAutomataParser.InicioContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="gramaticaAutomataParser.aceptacion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAceptacion([NotNull] gramaticaAutomataParser.AceptacionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="gramaticaAutomataParser.aceptacion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAceptacion([NotNull] gramaticaAutomataParser.AceptacionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="gramaticaAutomataParser.transiciones"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransiciones([NotNull] gramaticaAutomataParser.TransicionesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="gramaticaAutomataParser.transiciones"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransiciones([NotNull] gramaticaAutomataParser.TransicionesContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="gramaticaAutomataParser.transicion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransicion([NotNull] gramaticaAutomataParser.TransicionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="gramaticaAutomataParser.transicion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransicion([NotNull] gramaticaAutomataParser.TransicionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="gramaticaAutomataParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInput([NotNull] gramaticaAutomataParser.InputContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="gramaticaAutomataParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInput([NotNull] gramaticaAutomataParser.InputContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="gramaticaAutomataParser.estados"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEstados([NotNull] gramaticaAutomataParser.EstadosContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="gramaticaAutomataParser.estados"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEstados([NotNull] gramaticaAutomataParser.EstadosContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="gramaticaAutomataParser.estado"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEstado([NotNull] gramaticaAutomataParser.EstadoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="gramaticaAutomataParser.estado"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEstado([NotNull] gramaticaAutomataParser.EstadoContext context);
}
} // namespace ConsoleApp1
