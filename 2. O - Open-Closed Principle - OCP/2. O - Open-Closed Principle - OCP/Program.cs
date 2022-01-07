public class Program
{
    public static void Main(string[] args)
    {
        TypeVehicle type = TypeVehicle.CAR;

        if (type == TypeVehicle.CAR)
        {
            Vehicle vehicle = new Car("Azul", 2022, 2.0, 5, 4);
        }
        else
        {
            Vehicle vehicle = new Motorcycle("Branco", 2022, 250);
        }
    }
}