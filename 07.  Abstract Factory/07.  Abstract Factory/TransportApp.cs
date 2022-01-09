public class TransportApp
{
    private IAircraft aircraft;

    private ILandVehicle vehicle;

    public TransportApp(ITransportFactory factory)
    {
        vehicle = factory.CreateTransportVehicle();
        aircraft = factory.CreateTransportAircraft();
    }

    public void StartRoute()
    {
        vehicle.StartRoute();
        aircraft.StartRoute();
    }
}