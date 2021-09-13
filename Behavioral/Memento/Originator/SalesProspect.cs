using System;

namespace Memento
{
    public class SalesProspect
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public decimal Budget { get; set; }

        public Memento SaveMemento()
        {
            Console.WriteLine("\nSaving State... \n");
            return new Memento(Name, Phone, Budget);
        }

        internal void RestoreMemento(Memento memento)
        {
            Console.WriteLine("\nReturning State... \n");
            Name = memento.Name;
            Phone = memento.Phone;
            Budget = memento.Budget;
        }

        public void ShowStatus()
        {
            Console.WriteLine("\n -- Current Status");
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Phone = {Phone}");
            Console.WriteLine($"Budget = {Budget}");
        }
    }
}