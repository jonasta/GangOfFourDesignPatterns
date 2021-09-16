using System;

namespace Visitor
{
    public class IncomeVisitor : IVisitor
    {
        public void Visit(Clerk clerk)
        {
            Console.WriteLine("IncomeVisitor visits Clerk");
        }

        public void Visit(Director director)
        {
            Console.WriteLine("IncomeVisitor visits Director");
        }
    }
}