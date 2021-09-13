using System;

namespace Command
{
    public class Calculator
    {
        private int curr = 0;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': curr += operand; break;
                case '-': curr -= operand; break;
                case '*': curr *= operand; break;
                case '/': curr /= operand; break;
            }
            Console.WriteLine(
               "Current value = {0,3} (following {1} {2})",
               curr, @operator, operand);
        }
    }
}