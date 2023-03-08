using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
            StreamReader str = new StreamReader(args[0]);

            AntlrInputStream antlrInputStream = new AntlrInputStream(str);

            gramaticaAutomataLexer lexer = new gramaticaAutomataLexer(antlrInputStream);

            CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);

            gramaticaAutomataParser pruebaParser = new gramaticaAutomataParser(commonTokenStream);

            IParseTree parseTree = pruebaParser.automata();

            Console.WriteLine(parseTree.ToStringTree(pruebaParser));

            Console.ReadLine();
        }
    }
}
