namespace Visitor
{
    public class Director : Employee
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}