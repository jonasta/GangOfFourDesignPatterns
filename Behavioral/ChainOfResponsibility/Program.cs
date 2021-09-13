namespace ChainOfResponsibility
{
    internal static class Program
    {
        private static void Main()
        {
            Approver jhon = new Director();
            Approver mary = new VicePresident();
            Approver phil = new President();

            jhon.SetNextApprover(mary);
            mary.SetNextApprover(phil);

            jhon.ApproveRequest(1000);
            jhon.ApproveRequest(25000);
            jhon.ApproveRequest(250000);
            jhon.ApproveRequest(9000000);
        }
    }
}