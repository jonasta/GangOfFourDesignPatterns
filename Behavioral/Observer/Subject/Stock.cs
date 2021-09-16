using System.Collections.Generic;

namespace Observer
{
    public abstract class Stock
    {
        private readonly List<IInvestor> _investors = new();
        public string Symbol { get; }
        private double _quote;

        protected Stock(string symbol)
        {
            Symbol = symbol;
        }

        public double Quote
        {
            get => _quote;
            set
            {
                System.Console.WriteLine($"\n----- {Symbol} quote is now {value}");
                _quote = value;
                Notify();
            }
        }

        public void AttachInvestor(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void DetachInvestor(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (var investor in _investors)
            {
                investor.Update(this);
            }
        }
    }
}