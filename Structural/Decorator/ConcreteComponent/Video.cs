using System;

namespace Decorator
{
    public class Video : LibraryItem
    {
        private readonly string _director;

        public Video(string director, string title)
        {
            _director = director;
            Title = title;
        }

        public override void Display()
        {
            Console.WriteLine($"Video {Title} directed by {_director}");
        }
    }
}