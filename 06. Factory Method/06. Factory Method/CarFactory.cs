class CarFactory : TransportFactory
{
    protected override IVehicle CreateTransport()
    {
        return new Car();
    }
}