class Motorcycle : IVehicle
{
    public void GetCargo()
    {
        Console.WriteLine("Pegando a encomenda.");
    }

    public void StartRoute()
    {
        GetCargo();
        Console.WriteLine("Iniciando a entrega.");
    }
}