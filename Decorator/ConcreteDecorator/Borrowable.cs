using System;
using System.Collections.Generic;

namespace Decorator
{
    public class Borrowable : LibraryItemDecorator
    {
        protected readonly List<string> borrowers = new();

        public Borrowable(LibraryItem libraryItem) : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
        }

        public override void Display()
        {
            base.Display();
            foreach (string borrower in borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}