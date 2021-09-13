namespace Decorator
{
    internal static class Program
    {
        private static void Main()
        {
            Book book = new("Worley", "Inside ASP.NET");
            book.Display();

            Video video = new("Spielberg", "Jaws");
            video.Display();

            Borrowable borrowvideo = new(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");
            borrowvideo.Display();

            Borrowable borrowbook = new(book);
            borrowbook.BorrowItem("Customer #3");
            borrowbook.BorrowItem("Customer #4");
            borrowbook.Display();
        }
    }
}