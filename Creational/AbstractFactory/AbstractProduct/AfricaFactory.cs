﻿namespace AbstractFactory
{
    public class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
    }
}