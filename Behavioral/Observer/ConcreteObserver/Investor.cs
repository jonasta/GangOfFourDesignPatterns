using System;

namespace Observer
{
    public class Investor : IInvestor
    {
        private string Name { get; }

        public Investor(string name)
        {
            Name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine($"{Name} was notified that {stock.Symbol} quote is {stock.Quote}");
        }
    }
}