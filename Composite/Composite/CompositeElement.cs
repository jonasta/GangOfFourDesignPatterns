using System;
using System.Collections.Generic;

namespace Composite
{
    public class CompositeElement : BaseComponent
    {
        private readonly List<BaseComponent> _children = new();

        public CompositeElement(string name) : base(name)
        {
        }

        public override void Add(BaseComponent c)
        {
            _children.Add(c);
        }

        public override void Remove(BaseComponent c)
        {
            _children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
            // Recursively display child nodes
            foreach (BaseComponent component in _children)
            {
                component.Display(depth + 2);
            }
        }
    }
}