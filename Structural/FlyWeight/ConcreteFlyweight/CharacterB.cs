using System;

namespace FlyWeight
{
    public class CharacterB : Character
    {
        public CharacterB()
        {
            Symbol = 'B';
        }

        public override void Display(int pointSize)
        {
            PointSize = pointSize;
            Console.WriteLine($"{Symbol} (pointsize {PointSize})");
        }
    }
}