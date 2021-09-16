using System;
using System.Collections.Generic;

namespace TemplateMethod
{
    public class Categories : DataAcessor
    {
        private List<string> _items;

        protected override void AssembleList()
        {
            _items = new();
            _items.Add("Category 1");
            _items.Add("Category 2");
        }

        protected override void ShowData()
        {
            Console.WriteLine("\nShowing Categories List : ");
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }
}