namespace Composite
{
    internal static class Program
    {
        private static void Main()
        {
            CompositeElement root = new("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            CompositeElement branch = new("branch");
            branch.Add(new Leaf("Leaf XA"));
            branch.Add(new Leaf("Leaf XB"));

            root.Add(branch);
            root.Add(new Leaf("Leaf C"));

            root.Display(1);
        }
    }
}