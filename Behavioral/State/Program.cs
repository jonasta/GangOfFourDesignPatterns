using System;

namespace State
{
    internal static class Program
    {
        private static void Main()
        {
            Account account = new();

            account.Deposit(100);
            account.Deposit(11000);
            account.Withdraw(200);

            account.Withdraw(20000);
            account.Withdraw(300);

            Console.ReadKey();
        }
    }
}