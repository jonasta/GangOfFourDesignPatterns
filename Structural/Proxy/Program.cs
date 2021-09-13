using System;

namespace Proxy
{
    internal static class Program
    {
        private static void Main()
        {
            MathProxy proxy = new();

            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Subtract(4, 2));

            Console.ReadKey();
        }
    }
}