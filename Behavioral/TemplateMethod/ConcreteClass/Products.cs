using System;
using System.Collections.Generic;

namespace TemplateMethod
{
    public class Products : DataAcessor
    {
        private List<string> _items;

        protected override void AssembleList()
        {
            _items = new();
            _items.Add("Product 1");
            _items.Add("Product 2");
            _items.Add("Product 3");
        }

        protected override void ShowData()
        {
            Console.WriteLine("\nShowing Products List : ");
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }
}