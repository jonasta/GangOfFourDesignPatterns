namespace Builder
{
    public class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            vehicle = new Vehicle("Scooter");
        }

        public override void BuildPartA()
        {
            vehicle.Add("Scooter Part C");
        }

        public override void BuildPartB()
        {
            vehicle.Add("Scooter Part D");
        }

        public override Vehicle GetResult()
        {
            return vehicle;
        }
    }
}