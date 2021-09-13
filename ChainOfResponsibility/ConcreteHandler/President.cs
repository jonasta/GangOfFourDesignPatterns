using System;

namespace ChainOfResponsibility
{
    public class President : Approver
    {
        public override void ApproveRequest(double cost)
        {
            if (cost < 1000000)
            {
                Console.WriteLine($"President approved ${cost} request\n");
                return;
            }
            Console.WriteLine($"President wont´t approve ${cost} request. Out of budget.\n");
        }
    }
}