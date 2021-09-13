namespace Bridge
{
    public class BusinessObject
    {
        public DataObject DataObject { get; set; }

        public virtual void Operation()
        {
            DataObject.Operation();
        }
    }
}