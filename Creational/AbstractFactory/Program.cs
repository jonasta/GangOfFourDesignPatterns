using System;

namespace AbstractFactory
{
    internal static class Program
    {
        private static void Main()
        {
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new(africa);
            world.RunFoodChain();

            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            Console.ReadLine();
        }
    }
}