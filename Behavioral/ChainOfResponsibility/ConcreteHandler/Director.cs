using System;

namespace ChainOfResponsibility
{
    public class Director : Approver
    {
        public override void ApproveRequest(double cost)
        {
            if (cost < 10000)
            {
                Console.WriteLine($"Director approved ${cost} request\n");
                return;
            }
            Console.WriteLine($"Director can´t approved ${cost} request. Sending to {NextApprover.GetType().Name}");
            NextApprover?.ApproveRequest(cost);
        }
    }
}