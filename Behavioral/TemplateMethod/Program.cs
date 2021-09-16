namespace TemplateMethod
{
    internal static class Program
    {
        private static void Main()
        {
            DataAcessor categories = new Categories();
            categories.Run();

            DataAcessor products = new Products();
            products.Run();
        }
    }
}