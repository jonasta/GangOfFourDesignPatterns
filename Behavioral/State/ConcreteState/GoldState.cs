namespace State
{
    public class GoldState : State
    {
        public GoldState(State state)
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
            return 0.5;
        }

        public override void Withdraw(double ammount)
        {
            Balance -= ammount;
            StateChangeCheck();
        }

        protected override void StateChangeCheck()
        {
            if (Balance < 10000) Account.State = new SilverState(this);
            if (Balance < 0) Account.State = new RedState(this);
        }
    }
}