namespace Builder
{
    public abstract class VehicleBuilder
    {
        protected Vehicle vehicle;

        public abstract void BuildPartA();

        public abstract void BuildPartB();

        public abstract Vehicle GetResult();
    }
}