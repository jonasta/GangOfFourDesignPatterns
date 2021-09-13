using System;
using System.Collections.Generic;

namespace Command
{
    public class User
    {
        private readonly Calculator calculator = new();
        private readonly List<Command> commands = new();
        private int commandIndex = 0;

        public void Compute(char operation, int value)
        {
            Command command = new CalculatorCommand(operation, value, calculator);
            command.Execute();
            commands.Add(command);
            commandIndex++;
        }

        public void Redo(int levels)
        {
            Console.WriteLine($"\n Redoing {levels} operations...");
            for (int i = 0; i < levels; i++)
            {
                if (commandIndex < commands.Count - 1)
                {
                    commands[commandIndex++].Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine($"\n Undoing {levels} operations...");
            for (int i = 0; i < levels; i++)

            {
                if (commandIndex > 0)
                {
                    commands[--commandIndex].UnExecute();
                }
            }
        }
    }
}