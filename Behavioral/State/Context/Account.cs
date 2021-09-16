using System;

namespace State
{
    public class Account
    {
        public State State { get; set; }

        public Account()
        {
            State = new SilverState(0, this);
        }

        public void Deposit(double ammount)
        {
            State.Deposit(ammount);
            Console.WriteLine($"Deposited {ammount}, balance: {State.Balance} . Current state : {State.GetType().Name}");
        }

        public void Withdraw(double ammount)
        {
            State.Withdraw(ammount);
            Console.WriteLine($"Withdraw {ammount}, balance: {State.Balance} . Current state : {State.GetType().Name}");
        }

        public void ShowInterestRate()
        {
            Console.WriteLine($"Current account state is {State.GetType().Name} and interests are {State.GetRate()}");
        }
    }
}