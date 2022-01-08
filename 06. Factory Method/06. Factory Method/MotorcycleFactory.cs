class MotorcycleFactory : TransportFactory
{
    protected override IVehicle CreateTransport()
    {
        return new Motorcycle();
    }
}