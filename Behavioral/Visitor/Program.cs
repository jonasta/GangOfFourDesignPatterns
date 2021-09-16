namespace Visitor
{
    internal static class Program
    {
        private static void Main()
        {
            Employees employees = new();
            employees.Attach(new Clerk());
            employees.Attach(new Director());

            employees.Accept(new IncomeVisitor());
            employees.Accept(new VacationVisitor());
        }
    }
}