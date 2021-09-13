using System;

namespace Singleton
{
    internal static class Program
    {
        private static void Main()
        {
            LoadBalancer s1 = LoadBalancer.Instance();
            LoadBalancer s2 = LoadBalancer.Instance();
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }
            Console.ReadKey();
        }
    }
}