using System;

namespace Command
{
    public class CalculatorCommand : Command
    {
        private readonly char _operation;
        private readonly int _value;
        private readonly Calculator _calculator;

        public CalculatorCommand(char operation, int value, Calculator calculator)
        {
            _operation = operation;
            _value = value;
            _calculator = calculator;
        }

        public override void Execute()
        {
            _calculator.Operation(_operation, _value);
        }

        public override void UnExecute()
        {
            _calculator.Operation(Undo(_operation), _value);
        }

        private char Undo(char @operator)
        {
            return @operator switch
            {
                '+' => '-',
                '-' => '+',
                '*' => '/',
                '/' => '*',
                _ => throw new ArgumentException("@operator"),
            };
        }
    }
}