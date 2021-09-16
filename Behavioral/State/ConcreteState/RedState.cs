using System;

namespace State
{
    public class RedState : State
    {
        public RedState(State state)
        {
            Account = state.Account;
            Balance = state.Balance;
        }

        public override void Deposit(double ammount)
        {
            Balance += ammount;
            StateChangeCheck();
        }

        public override double GetRate()
        {
            return 15;
        }

        public override void Withdraw(double ammount)
        {
            Console.WriteLine("No Funds =(");
        }

        protected override void StateChangeCheck()
        {
            if (Balance > 0)
            {
                Account.State = new SilverState(this);
            }
        }
    }
}