namespace ChainOfResponsibility
{
    public abstract class Approver
    {
        protected Approver NextApprover;

        public void SetNextApprover(Approver approver)
        {
            NextApprover = approver;
        }

        public abstract void ApproveRequest(double cost);
    }
}