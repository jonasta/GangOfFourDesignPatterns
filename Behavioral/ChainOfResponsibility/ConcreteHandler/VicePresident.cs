using System;

namespace ChainOfResponsibility
{
    public class VicePresident : Approver
    {
        public override void ApproveRequest(double cost)
        {
            if (cost < 100000)
            {
                Console.WriteLine($"Vice President approved ${cost} request\n");
                return;
            }
            Console.WriteLine($"Vice President can´t approved ${cost} request. Sending to {NextApprover.GetType().Name}");
            NextApprover?.ApproveRequest(cost);
        }
    }
}