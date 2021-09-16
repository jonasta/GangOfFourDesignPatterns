namespace State
{
    public class SilverState : State
    {
        public SilverState(double balance, Account account)
        {
            Balance = balance;
            Account = account;
        }

        public SilverState(State state)
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
            return 3;
        }

        public override void Withdraw(double ammount)
        {
            Balance -= ammount;
            StateChangeCheck();
        }

        protected override void StateChangeCheck()
        {
            if (Balance > 10000) Account.State = new GoldState(this);
            if (Balance < 0) Account.State = new RedState(this);
        }
    }
}