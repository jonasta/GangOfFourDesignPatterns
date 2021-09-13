using System;

namespace Prototype
{
    public class Color : ColorPrototype
    {
        private readonly int _red;
        private readonly int _green;
        private readonly int _blue;

        public Color(int red, int green, int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }

        public override ColorPrototype Clone()
        {
            Console.WriteLine("Cloning color RGB: {0,5},{1,5},{2,5}", _red, _green, _blue);
            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}