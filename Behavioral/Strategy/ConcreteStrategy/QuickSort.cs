using System;
using System.Collections.Generic;

namespace Strategy
{
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("\nSorting with QuickSort");
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}