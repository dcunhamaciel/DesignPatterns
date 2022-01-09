public interface ITransportFactory
{
    public ILandVehicle CreateTransportVehicle();

    public IAircraft CreateTransportAircraft();
}