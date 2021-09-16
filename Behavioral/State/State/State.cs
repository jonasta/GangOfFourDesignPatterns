namespace State
{
    public abstract class State
    {
        public Account Account { get; set; }
        public double Balance { get; set; }

        public abstract void Deposit(double ammount);

        public abstract void Withdraw(double ammount);

        public abstract double GetRate();

        protected abstract void StateChangeCheck();
    }
}