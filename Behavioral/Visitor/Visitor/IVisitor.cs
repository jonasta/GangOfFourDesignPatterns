namespace Visitor
{
    public interface IVisitor
    {
        void Visit(Clerk clerk);

        void Visit(Director director);
    }
}