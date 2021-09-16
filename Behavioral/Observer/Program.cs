namespace Observer
{
    internal static class Program
    {
        private static void Main()
        {
            IBM ibm = new("IBM");
            ibm.AttachInvestor(new Investor("Jon"));
            ibm.AttachInvestor(new Investor("Mary"));
            Investor Louis = new("Louis");
            ibm.AttachInvestor(Louis);

            ibm.Quote = 14.1;
            ibm.Quote = 14.5;
            ibm.Quote = 15;

            ibm.DetachInvestor(Louis);
            ibm.Quote = 12;
        }
    }
}