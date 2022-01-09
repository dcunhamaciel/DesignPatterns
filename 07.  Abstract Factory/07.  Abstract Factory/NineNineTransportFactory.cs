public class NineNineTransportFactory : ITransportFactory
{
    public IAircraft CreateTransportAircraft()
    {
        return new Helicopter();
    }

    public ILandVehicle CreateTransportVehicle()
    {
        return new Motorcycle();
    }
}