abstract class TransportFactory
{
    public void StartTransport()
    {
        IVehicle vehicle = CreateTransport();
        vehicle.StartRoute();
    }

    protected abstract IVehicle CreateTransport();
}