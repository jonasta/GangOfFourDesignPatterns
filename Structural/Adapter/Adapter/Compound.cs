using System;

namespace Adapter
{
    public class Compound
    {
        protected string molecularFormula;
        protected double molecularWeight;

        public virtual void Display()
        {
            Console.WriteLine("\nCompound: Unknown ------ ");
        }
    }
}