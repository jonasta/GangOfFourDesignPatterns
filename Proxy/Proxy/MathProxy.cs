namespace Proxy
{
    public class MathProxy : IMath
    {
        private readonly Math _math = new();

        public double Add(double a, double b)
        {
            return _math.Add(a, b);
        }

        public double Subtract(double a, double b)
        {
            return _math.Subtract(a, b);
        }
    }
}