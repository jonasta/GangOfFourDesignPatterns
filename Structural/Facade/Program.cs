namespace Facade
{
    internal static class Program
    {
        private static void Main()
        {
            SystemsFacade facade = new();
            facade.MethodA();
            facade.MethodB();
        }
    }
}