namespace Builder
{
    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            vehicle = new Vehicle("Car");
        }

        public override void BuildPartA()
        {
            vehicle.Add("Car Part X");
        }

        public override void BuildPartB()
        {
            vehicle.Add("Car Part Y");
        }

        public override Vehicle GetResult()
        {
            return vehicle;
        }
    }
}