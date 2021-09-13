using System;

namespace Adapter
{
    internal static class Program
    {
        private static void Main()
        {
            Compound unknown = new();
            unknown.Display();

            Compound water = new RichCompound("Water");
            water.Display();
            Console.ReadKey();
        }
    }
}