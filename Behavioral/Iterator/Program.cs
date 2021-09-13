using System;

namespace Iterator
{
    internal static class Program
    {
        private static void Main()
        {
            Collection collection = new();
            for (int i = 0; i <= 410; i++)
            {
                collection[i] = new Item($"Item {i}");
            }
            Iterator iterator = collection.CreateIterator();
            iterator.Step = 3;
            Console.WriteLine("Iterating over collection:");
            for (Item item = iterator.First(); !iterator.IsDone(); item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }
    }
}