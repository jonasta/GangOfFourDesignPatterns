using System;

namespace FlyWeight
{
    public class CharacterA : Character
    {
        public CharacterA()
        {
            Symbol = 'A';
        }

        public override void Display(int pointSize)
        {
            PointSize = pointSize;
            Console.WriteLine($"{Symbol} (pointsize {PointSize})");
        }
    }
}