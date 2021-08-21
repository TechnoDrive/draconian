using System;
using Implementation.Lexer.Token;

namespace Implementation {
    internal static class Program {
        public static void Main(string[] args) {
            if (args.Length != 2) {
                Console.WriteLine("Usage: draconian path/to/input.dracon path/to/output.js");
            } else {
                Lexer.Lexer lexer = new Lexer.Lexer();
                foreach (Token token in lexer.Tokenize(System.IO.File.ReadAllText(args[0]))) {
                    Console.WriteLine(token);
                }
            }
        }
    }
}