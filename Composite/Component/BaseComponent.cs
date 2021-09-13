namespace Composite
{
    public abstract class BaseComponent
    {
        protected string Name { get; }

        protected BaseComponent(string name)
        {
            Name = name;
        }

        public abstract void Add(BaseComponent c);

        public abstract void Remove(BaseComponent c);

        public abstract void Display(int depth);
    }
}