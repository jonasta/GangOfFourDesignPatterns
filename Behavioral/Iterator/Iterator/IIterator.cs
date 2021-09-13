namespace Iterator
{
    public interface IIterator
    {
        Item First();

        bool IsDone();

        Item Next();

        Item CurrentItem { get; }
    }
}