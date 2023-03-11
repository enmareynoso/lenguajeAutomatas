using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;

namespace ConsoleApp1
{
    public class Transicion
    {
        public string origen;
        public string destino;
        public string input;
        public const string op = "->";
        public Transicion(string o, string d, string i)
        {
            this.origen = o;
            this.destino = d;
            this.input = i;
        }
    }
    class Class1 : gramaticaAutomataBaseVisitor<string>
    {
        public List<string> estados = new List<string>();
        public List<string> estadosAceptacion = new List<string>();
        public string estadoInicial = "";
        public List<Transicion> transicions = new List<Transicion>();

        public override string VisitAutomata([NotNull] gramaticaAutomataParser.AutomataContext context)
        {
            string inicio = Visit(context.inicio());
            string aceptacion = Visit(context.aceptacion());
            string transiciones = Visit(context.transiciones());
            return "";
        }

        //finished
        public override string VisitAceptacion([NotNull] gramaticaAutomataParser.AceptacionContext context)
        {
            int n = 0;
            foreach(var aceptacion in context.estados().estado())
            {
                if (n != 0)
                {
                    estadosAceptacion.Add(", " + Visit(aceptacion));
                }
                else
                {
                    estadosAceptacion.Add(Visit(aceptacion));
                }
                n++;
                
            }
    
            return "";  
        }
        //Finished
        public override string VisitEstado([NotNull] gramaticaAutomataParser.EstadoContext context)
        {
            return context.ID().GetText();
        }
        //Finished
        public override string VisitInput([NotNull] gramaticaAutomataParser.InputContext context)
        {
            string inputs = "";
            int n = 0;
            foreach(var input in context.DIGITO())
            {
                if(n != 0)
                {
                    inputs += ", " + input;
                }
                else
                {
                    inputs += input;
                }
                n++;
            }
            return inputs;
        }
        //Finished
        public override string VisitTransiciones([NotNull] gramaticaAutomataParser.TransicionesContext context)
        {
            foreach(var transition in context.transicion())
            {
                Visit(transition);
            }
            return "";
        }

        //finished siempre vacio debido a que hay reglas que parsean mas que esta regla
        public override string VisitEstados([NotNull] gramaticaAutomataParser.EstadosContext context)
        {
            foreach(var estado in context.estado())
            {
                estados.Add(Visit(estado));
            }
            return "";
        }
        //Finished
        public override string VisitTransicion([NotNull] gramaticaAutomataParser.TransicionContext context)
        {
            string inicio = Visit(context.estado()[0]);
            string destino = Visit(context.estado()[1]);
            string input = Visit(context.input());
            Transicion newTransition = new Transicion(inicio, destino, input);
            transicions.Add(newTransition);
            return "";
        }
        //Finished
        public override string VisitInicio([NotNull] gramaticaAutomataParser.InicioContext context)
        {
            estadoInicial = Visit(context.estado());
            return Visit(context.estado());
        }
    }
}
