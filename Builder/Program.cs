namespace Builder
{
    internal static class Program
    {
        private static void Main()
        {
            Shop shop = new();

            VehicleBuilder motorcycleBuilder = new MotorcycleBuilder();
            shop.Construct(motorcycleBuilder);
            Vehicle motorcycle = motorcycleBuilder.GetResult();
            motorcycle.Show();

            VehicleBuilder carBuilder = new CarBuilder();
            shop.Construct(carBuilder);
            Vehicle car = carBuilder.GetResult();
            car.Show();

            VehicleBuilder scooterBuilder = new ScooterBuilder();
            shop.Construct(scooterBuilder);
            Vehicle scooter = scooterBuilder.GetResult();
            scooter.Show();
        }
    }
}