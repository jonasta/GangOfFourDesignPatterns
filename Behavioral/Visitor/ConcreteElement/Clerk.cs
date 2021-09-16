namespace Visitor
{
    public class Clerk : Employee
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}