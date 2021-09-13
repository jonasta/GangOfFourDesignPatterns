using System;

namespace FactoryMethod
{
    internal static class Program
    {
        private static void Main()
        {
            Document[] documents = new Document[] { new Report(), new Resume() };

            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");

                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
        }
    }
}