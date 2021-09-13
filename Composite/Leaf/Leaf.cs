using System;

namespace Composite
{
    public class Leaf : BaseComponent

    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(BaseComponent c)
        {
            Console.WriteLine("Cannot add to leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
        }

        public override void Remove(BaseComponent c)
        {
            Console.WriteLine("Cannot remove from  leaf");
        }
    }
}