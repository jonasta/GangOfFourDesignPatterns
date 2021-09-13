using System;

namespace Decorator
{
    public class Book : LibraryItem
    {
        private readonly string _author;

        public Book(string author, string title)
        {
            _author = author;
            Title = title;
        }

        public override void Display()
        {
            Console.WriteLine($"Book {Title} by {_author}");
        }
    }
}