using System;

namespace Command
{
    internal static class Program
    {
        private static void Main()
        {
            User jhon = new();
            jhon.Compute('+', 100);
            jhon.Compute('+', 50);
            jhon.Compute('+', 100);
            jhon.Compute('*', 2);
            jhon.Compute('/', 2);
            jhon.Undo(3);
            jhon.Redo(2);
            Console.ReadKey();
        }
    }
}