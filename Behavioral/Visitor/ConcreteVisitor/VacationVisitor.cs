using System;

namespace Visitor
{
    public class VacationVisitor : IVisitor
    {
        public void Visit(Clerk clerk)
        {
            Console.WriteLine("VacationVisitor visits Clerk");
        }

        public void Visit(Director director)
        {
            Console.WriteLine("VacationVisitor visits Director");
        }
    }
}