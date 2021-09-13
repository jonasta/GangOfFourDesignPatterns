namespace Bridge
{
    public class CustomerBusinessObject : BusinessObject
    {
        public override void Operation()
        {
            DataObject.Operation();
        }
    }
}