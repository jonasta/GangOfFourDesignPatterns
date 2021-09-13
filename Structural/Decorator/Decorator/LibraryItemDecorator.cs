namespace Decorator
{
    public abstract class LibraryItemDecorator : LibraryItem
    {
        protected LibraryItem LibraryItem;

        protected LibraryItemDecorator(LibraryItem libraryItem)
        {
            LibraryItem = libraryItem;
        }

        public override void Display()
        {
            LibraryItem.Display();
        }
    }
}