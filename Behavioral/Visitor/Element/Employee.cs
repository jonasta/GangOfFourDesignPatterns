namespace Visitor
{
    public abstract class Employee
    {
        public abstract void Accept(IVisitor visitor);
    }
}