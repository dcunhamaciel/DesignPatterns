public class Program
{
    public static void Main(string[] args)
    {
        VehicleBuilder builder = new VehicleBuilder();
        Director director = new Director(builder);

        director.ConstructSedanCar();
        Vehicle sedan = builder.GetVehicle();
        Console.WriteLine(sedan);

        director.ConstructSUV();
        Vehicle suv = builder.GetVehicle();
        Console.WriteLine(suv);

        director.ConstructTruck();
        Vehicle truck = builder.GetVehicle();
        Console.WriteLine(truck);
    }
}