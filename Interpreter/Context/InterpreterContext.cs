namespace Interpreter
{
    public class InterpreterContext
    {
        public string Input { get; set; }

        public int Output { get; set; }

        public InterpreterContext(string input)
        {
            Input = input;
        }
    }
}