using System;
using System.Collections.Generic;

namespace Interpreter
{
    internal static class Program
    {
        private static void Main()
        {
            const string roman = "MCMXXVIII";
            InterpreterContext context = new(roman);
            List<Expression> tree = new()
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            foreach (Expression expression in tree)
            {
                expression.Interpret(context);
            }
            Console.WriteLine("{0} = {1}",
               roman, context.Output);
            Console.ReadKey();
        }
    }
}