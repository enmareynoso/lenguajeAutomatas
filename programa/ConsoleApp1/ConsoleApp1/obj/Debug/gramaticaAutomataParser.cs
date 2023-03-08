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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class gramaticaAutomataParser : Parser {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, TipoAutomata=12, ID=13, DIGITO=14, WS=15;
	public const int
		RULE_automata = 0, RULE_tipo = 1, RULE_inicio = 2, RULE_aceptacion = 3, 
		RULE_transiciones = 4, RULE_transicion = 5, RULE_input = 6, RULE_estados = 7, 
		RULE_estado = 8;
	public static readonly string[] ruleNames = {
		"automata", "tipo", "inicio", "aceptacion", "transiciones", "transicion", 
		"input", "estados", "estado"
	};

	private static readonly string[] _LiteralNames = {
		null, "'Automata:'", "'Tipo:'", "'Inicio:'", "'Aceptacion:'", "'{'", "'}'", 
		"'Transiciones:'", "':'", "'->'", "'vacio'", "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		"TipoAutomata", "ID", "DIGITO", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "gramaticaAutomata.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public gramaticaAutomataParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class AutomataContext : ParserRuleContext {
		public TipoContext tipo() {
			return GetRuleContext<TipoContext>(0);
		}
		public InicioContext inicio() {
			return GetRuleContext<InicioContext>(0);
		}
		public AceptacionContext aceptacion() {
			return GetRuleContext<AceptacionContext>(0);
		}
		public TransicionesContext transiciones() {
			return GetRuleContext<TransicionesContext>(0);
		}
		public AutomataContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_automata; } }
		public override void EnterRule(IParseTreeListener listener) {
			IgramaticaAutomataListener typedListener = listener as IgramaticaAutomataListener;
			if (typedListener != null) typedListener.EnterAutomata(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IgramaticaAutomataListener typedListener = listener as IgramaticaAutomataListener;
			if (typedListener != null) typedListener.ExitAutomata(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IgramaticaAutomataVisitor<TResult> typedVisitor = visitor as IgramaticaAutomataVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAutomata(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AutomataContext automata() {
		AutomataContext _localctx = new AutomataContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_automata);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 18; Match(T__0);
			State = 19; tipo();
			State = 20; inicio();
			State = 21; aceptacion();
			State = 22; transiciones();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TipoContext : ParserRuleContext {
		public ITerminalNode TipoAutomata() { return GetToken(gramaticaAutomataParser.TipoAutomata, 0); }
		public TipoContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tipo; } }
		public override void EnterRule(IParseTreeListener listener) {
			IgramaticaAutomataListener typedListener = listener as IgramaticaAutomataListener;
			if (typedListener != null) typedListener.EnterTipo(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IgramaticaAutomataListener typedListener = listener as IgramaticaAutomataListener;
			if (typedListener != null) typedListener.ExitTipo(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IgramaticaAutomataVisitor<TResult> typedVisitor = visitor as IgramaticaAutomataVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTipo(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TipoContext tipo() {
		TipoContext _localctx = new TipoContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_tipo);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 24; Match(T__1);
			State = 25; Match(TipoAutomata);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InicioContext : ParserRuleContext {
		public EstadoContext estado() {
			return GetRuleContext<EstadoContext>(0);
		}
		public InicioContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_inicio; } }
		public override void EnterRule(IParseTreeListener listener) {
			IgramaticaAutomataListener typedListener = listener as IgramaticaAutomataListener;
			if (typedListener != null) typedListener.EnterInicio(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IgramaticaAutomataListener typedListener = listener as IgramaticaAutomataListener;
			if (typedListener != null) typedListener.ExitInicio(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IgramaticaAutomataVisitor<TResult> typedVisitor = visitor as IgramaticaAutomataVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInicio(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public InicioContext inicio() {
		InicioContext _localctx = new InicioContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_inicio);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 27; Match(T__2);
			State = 28; estado();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AceptacionContext : ParserRuleContext {
		public EstadosContext estados() {
			return GetRuleContext<EstadosContext>(0);
		}
		public AceptacionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_aceptacion; } }
		public override void EnterRule(IParseTreeListener listener) {
			IgramaticaAutomataListener typedListener = listener as IgramaticaAutomataListener;
			if (typedListener != null) typedListener.EnterAceptacion(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IgramaticaAutomataListener typedListener = listener as IgramaticaAutomataListener;
			if (typedListener != null) typedListener.ExitAceptacion(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IgramaticaAutomataVisitor<TResult> typedVisitor = visitor as IgramaticaAutomataVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAceptacion(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AceptacionContext aceptacion() {
		AceptacionContext _localctx = new AceptacionContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_aceptacion);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 30; Match(T__3);
			State = 31; Match(T__4);
			State = 32; estados();
			State = 33; Match(T__5);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TransicionesContext : ParserRuleContext {
		public TransicionContext[] transicion() {
			return GetRuleContexts<TransicionContext>();
		}
		public TransicionContext transicion(int i) {
			return GetRuleContext<TransicionContext>(i);
		}
		public TransicionesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_transiciones; } }
		public override void EnterRule(IParseTreeListener listener) {
			IgramaticaAutomataListener typedListener = listener as IgramaticaAutomataListener;
			if (typedListener != null) typedListener.EnterTransiciones(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IgramaticaAutomataListener typedListener = listener as IgramaticaAutomataListener;
			if (typedListener != null) typedListener.ExitTransiciones(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IgramaticaAutomataVisitor<TResult> typedVisitor = visitor as IgramaticaAutomataVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTransiciones(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TransicionesContext transiciones() {
		TransicionesContext _localctx = new TransicionesContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_transiciones);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 35; Match(T__6);
			State = 36; transicion();
			State = 41;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==T__7) {
				{
				{
				State = 37; Match(T__7);
				State = 38; transicion();
				}
				}
				State = 43;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TransicionContext : ParserRuleContext {
		public EstadoContext[] estado() {
			return GetRuleContexts<EstadoContext>();
		}
		public EstadoContext estado(int i) {
			return GetRuleContext<EstadoContext>(i);
		}
		public EstadosContext estados() {
			return GetRuleContext<EstadosContext>(0);
		}
		public InputContext input() {
			return GetRuleContext<InputContext>(0);
		}
		public TransicionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_transicion; } }
		public override void EnterRule(IParseTreeListener listener) {
			IgramaticaAutomataListener typedListener = listener as IgramaticaAutomataListener;
			if (typedListener != null) typedListener.EnterTransicion(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IgramaticaAutomataListener typedListener = listener as IgramaticaAutomataListener;
			if (typedListener != null) typedListener.ExitTransicion(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IgramaticaAutomataVisitor<TResult> typedVisitor = visitor as IgramaticaAutomataVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTransicion(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TransicionContext transicion() {
		TransicionContext _localctx = new TransicionContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_transicion);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 44; estado();
			State = 45; Match(T__8);
			State = 51;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case ID:
				{
				State = 46; estado();
				}
				break;
			case T__4:
				{
				State = 47; Match(T__4);
				State = 48; estados();
				State = 49; Match(T__5);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 53; Match(T__7);
			State = 56;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case T__10:
			case DIGITO:
				{
				State = 54; input();
				}
				break;
			case T__9:
				{
				State = 55; Match(T__9);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InputContext : ParserRuleContext {
		public ITerminalNode[] DIGITO() { return GetTokens(gramaticaAutomataParser.DIGITO); }
		public ITerminalNode DIGITO(int i) {
			return GetToken(gramaticaAutomataParser.DIGITO, i);
		}
		public InputContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_input; } }
		public override void EnterRule(IParseTreeListener listener) {
			IgramaticaAutomataListener typedListener = listener as IgramaticaAutomataListener;
			if (typedListener != null) typedListener.EnterInput(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IgramaticaAutomataListener typedListener = listener as IgramaticaAutomataListener;
			if (typedListener != null) typedListener.ExitInput(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IgramaticaAutomataVisitor<TResult> typedVisitor = visitor as IgramaticaAutomataVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInput(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public InputContext input() {
		InputContext _localctx = new InputContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_input);
		int _la;
		try {
			State = 64;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case DIGITO:
				EnterOuterAlt(_localctx, 1);
				{
				State = 59;
				_errHandler.Sync(this);
				_la = _input.La(1);
				do {
					{
					{
					State = 58; Match(DIGITO);
					}
					}
					State = 61;
					_errHandler.Sync(this);
					_la = _input.La(1);
				} while ( _la==DIGITO );
				}
				break;
			case T__10:
				EnterOuterAlt(_localctx, 2);
				{
				State = 63; Match(T__10);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EstadosContext : ParserRuleContext {
		public EstadoContext[] estado() {
			return GetRuleContexts<EstadoContext>();
		}
		public EstadoContext estado(int i) {
			return GetRuleContext<EstadoContext>(i);
		}
		public EstadosContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_estados; } }
		public override void EnterRule(IParseTreeListener listener) {
			IgramaticaAutomataListener typedListener = listener as IgramaticaAutomataListener;
			if (typedListener != null) typedListener.EnterEstados(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IgramaticaAutomataListener typedListener = listener as IgramaticaAutomataListener;
			if (typedListener != null) typedListener.ExitEstados(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IgramaticaAutomataVisitor<TResult> typedVisitor = visitor as IgramaticaAutomataVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitEstados(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public EstadosContext estados() {
		EstadosContext _localctx = new EstadosContext(_ctx, State);
		EnterRule(_localctx, 14, RULE_estados);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 66; estado();
			State = 71;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==T__10) {
				{
				{
				State = 67; Match(T__10);
				State = 68; estado();
				}
				}
				State = 73;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EstadoContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(gramaticaAutomataParser.ID, 0); }
		public EstadoContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_estado; } }
		public override void EnterRule(IParseTreeListener listener) {
			IgramaticaAutomataListener typedListener = listener as IgramaticaAutomataListener;
			if (typedListener != null) typedListener.EnterEstado(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IgramaticaAutomataListener typedListener = listener as IgramaticaAutomataListener;
			if (typedListener != null) typedListener.ExitEstado(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IgramaticaAutomataVisitor<TResult> typedVisitor = visitor as IgramaticaAutomataVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitEstado(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public EstadoContext estado() {
		EstadoContext _localctx = new EstadoContext(_ctx, State);
		EnterRule(_localctx, 16, RULE_estado);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 74; Match(ID);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x11O\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t"+
		"\t\x4\n\t\n\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x4"+
		"\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\a\x6"+
		"*\n\x6\f\x6\xE\x6-\v\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x5\a\x36\n"+
		"\a\x3\a\x3\a\x3\a\x5\a;\n\a\x3\b\x6\b>\n\b\r\b\xE\b?\x3\b\x5\b\x43\n\b"+
		"\x3\t\x3\t\x3\t\a\tH\n\t\f\t\xE\tK\v\t\x3\n\x3\n\x3\n\x2\x2\x2\v\x2\x2"+
		"\x4\x2\x6\x2\b\x2\n\x2\f\x2\xE\x2\x10\x2\x12\x2\x2\x2K\x2\x14\x3\x2\x2"+
		"\x2\x4\x1A\x3\x2\x2\x2\x6\x1D\x3\x2\x2\x2\b \x3\x2\x2\x2\n%\x3\x2\x2\x2"+
		"\f.\x3\x2\x2\x2\xE\x42\x3\x2\x2\x2\x10\x44\x3\x2\x2\x2\x12L\x3\x2\x2\x2"+
		"\x14\x15\a\x3\x2\x2\x15\x16\x5\x4\x3\x2\x16\x17\x5\x6\x4\x2\x17\x18\x5"+
		"\b\x5\x2\x18\x19\x5\n\x6\x2\x19\x3\x3\x2\x2\x2\x1A\x1B\a\x4\x2\x2\x1B"+
		"\x1C\a\xE\x2\x2\x1C\x5\x3\x2\x2\x2\x1D\x1E\a\x5\x2\x2\x1E\x1F\x5\x12\n"+
		"\x2\x1F\a\x3\x2\x2\x2 !\a\x6\x2\x2!\"\a\a\x2\x2\"#\x5\x10\t\x2#$\a\b\x2"+
		"\x2$\t\x3\x2\x2\x2%&\a\t\x2\x2&+\x5\f\a\x2\'(\a\n\x2\x2(*\x5\f\a\x2)\'"+
		"\x3\x2\x2\x2*-\x3\x2\x2\x2+)\x3\x2\x2\x2+,\x3\x2\x2\x2,\v\x3\x2\x2\x2"+
		"-+\x3\x2\x2\x2./\x5\x12\n\x2/\x35\a\v\x2\x2\x30\x36\x5\x12\n\x2\x31\x32"+
		"\a\a\x2\x2\x32\x33\x5\x10\t\x2\x33\x34\a\b\x2\x2\x34\x36\x3\x2\x2\x2\x35"+
		"\x30\x3\x2\x2\x2\x35\x31\x3\x2\x2\x2\x36\x37\x3\x2\x2\x2\x37:\a\n\x2\x2"+
		"\x38;\x5\xE\b\x2\x39;\a\f\x2\x2:\x38\x3\x2\x2\x2:\x39\x3\x2\x2\x2;\r\x3"+
		"\x2\x2\x2<>\a\x10\x2\x2=<\x3\x2\x2\x2>?\x3\x2\x2\x2?=\x3\x2\x2\x2?@\x3"+
		"\x2\x2\x2@\x43\x3\x2\x2\x2\x41\x43\a\r\x2\x2\x42=\x3\x2\x2\x2\x42\x41"+
		"\x3\x2\x2\x2\x43\xF\x3\x2\x2\x2\x44I\x5\x12\n\x2\x45\x46\a\r\x2\x2\x46"+
		"H\x5\x12\n\x2G\x45\x3\x2\x2\x2HK\x3\x2\x2\x2IG\x3\x2\x2\x2IJ\x3\x2\x2"+
		"\x2J\x11\x3\x2\x2\x2KI\x3\x2\x2\x2LM\a\xF\x2\x2M\x13\x3\x2\x2\x2\b+\x35"+
		":?\x42I";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace ConsoleApp1