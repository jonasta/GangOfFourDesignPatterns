namespace Builder
{
    public class Shop
    {
        internal void Construct(VehicleBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}