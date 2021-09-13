using System;

namespace Prototype
{
    internal static class Program
    {
        private static void Main()
        {
            ColorManager colormanager = new();

            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);
            _ = colormanager["red"].Clone() as Color;
            _ = colormanager["green"].Clone() as Color;
            _ = colormanager["blue"].Clone() as Color;

            Console.ReadKey();
        }
    }
}