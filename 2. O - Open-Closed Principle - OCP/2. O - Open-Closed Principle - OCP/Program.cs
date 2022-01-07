public class Program
{
    public static void Main(string[] args)
    {
        TypeVehicle type = TypeVehicle.CAR;

        if (type == TypeVehicle.CAR)
        {
            Vehicle vehicle = new Vehicle("Azul", 2022, 2.0, 5, 4);
            vehicle.Car();
        }
        else
        {
            Vehicle vehicle = new Vehicle("Branco", 2022, 250, 0, 0);
            vehicle.Motorcycle();
        }
    }
}