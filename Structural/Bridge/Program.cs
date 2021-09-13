using System;

namespace Bridge
{
    internal static class Program
    {
        private static void Main()
        {
            BusinessObject businessObject = new CustomerBusinessObject
            {
                DataObject = new CustomersDataObject()
            };
            businessObject.Operation();

            businessObject.DataObject = new VendorsDataObject();
            businessObject.Operation();

            Console.ReadKey();
        }
    }
}