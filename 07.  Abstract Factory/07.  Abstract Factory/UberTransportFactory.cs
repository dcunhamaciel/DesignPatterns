public class UberTransportFactory : ITransportFactory
{
    public IAircraft CreateTransportAircraft()
    {
        return new Airplane();
    }

    public ILandVehicle CreateTransportVehicle()
    {
        return new Car();
    }
}