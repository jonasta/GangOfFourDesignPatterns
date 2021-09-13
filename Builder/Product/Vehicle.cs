using System;
using System.Collections.Generic;

namespace Builder
{
    public class Vehicle
    {
        private readonly string _vehicleType;
        private readonly List<string> _parts = new();

        public Vehicle(string type)
        {
            _vehicleType = type;
        }

        internal void Add(string part)
        {
            _parts.Add(part);
        }

        internal void Show()
        {
            Console.WriteLine("\nProduct type is {0}", _vehicleType);
            Console.WriteLine("\nProduct Parts -------");
            foreach (string part in _parts)
                Console.WriteLine(part);
        }
    }
}