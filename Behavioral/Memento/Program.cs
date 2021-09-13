using System;

namespace Memento
{
    internal static class Program
    {
        private static void Main()
        {
            SalesProspect salesProspect = new();
            salesProspect.Name = "Jonasta dos Santos";
            salesProspect.Phone = "+55 41 98888-4444";
            salesProspect.Budget = 2555;
            salesProspect.ShowStatus();

            ProspectMemory prospectMemory = new();
            prospectMemory.Memento = salesProspect.SaveMemento();

            salesProspect.Name = "João da Silva";
            salesProspect.Phone = "+55 47 88888-7777";
            salesProspect.Budget = 888;
            salesProspect.ShowStatus();

            salesProspect.RestoreMemento(prospectMemory.Memento);
            salesProspect.ShowStatus();

            Console.ReadKey();
        }
    }
}