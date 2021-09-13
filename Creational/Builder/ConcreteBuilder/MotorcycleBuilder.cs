namespace Builder
{
    public class MotorcycleBuilder : VehicleBuilder
    {
        public MotorcycleBuilder()
        {
            vehicle = new Vehicle("Motorcycle");
        }

        public override void BuildPartA()
        {
            vehicle.Add("Motorcycle Part A");
        }

        public override void BuildPartB()
        {
            vehicle.Add("Motorcycle Part B");
        }

        public override Vehicle GetResult()
        {
            return vehicle;
        }
    }
}