using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.Text.Json;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting the lexer and parser
            StreamReader str = new StreamReader(args[0]);

            AntlrInputStream antlrInputStream = new AntlrInputStream(str);

            gramaticaAutomataLexer lexer = new gramaticaAutomataLexer(antlrInputStream);

            CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);

            gramaticaAutomataParser pruebaParser = new gramaticaAutomataParser(commonTokenStream);

            var parseTree = pruebaParser.automata();

            //Setting the Visitor
            Class1 visitor = new Class1();
            visitor.VisitAutomata(parseTree);

            //Fixing some strings
            string transitionsString = "";
            string estadosAceptacionString = ""; 
            foreach(Transicion transicion in visitor.transicions)
            {
                transitionsString += $"\n\t {transicion.origen} {Transicion.op} {transicion.destino} [label = \"{transicion.input}\"];";
            }
            foreach(string estado in visitor.estadosAceptacion)
            {
                estadosAceptacionString += estado;
            }
            // .DOT format
            string automataDotFix = $"digraph Automata {{\n\trankdir=LR \n \tnode [shape = none, height=0, width=0]; " +
                   $"flechaInicio [label=\"\"]; \n\tnode [shape = doublecircle]; {estadosAceptacionString};  \n\tnode [shape = circle];" +
                   $"\n\tflechaInicio -> {visitor.estadoInicial};  {transitionsString}  \n}}";

           //Test
           Console.WriteLine(automataDotFix);
           Console.ReadLine();
        }

       
    }
}
