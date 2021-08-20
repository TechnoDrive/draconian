using System;

namespace Implementation {
    internal static class Program {
        public static void Main(string[] args) {
            if (args.Length != 2) {
                Console.WriteLine("Usage: draconian path/to/input.dracon path/to/output.js");
            }
        }
    }
}