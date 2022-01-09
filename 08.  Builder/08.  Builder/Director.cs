public class Director
{

    IBuilder Builder;

    public Director(IBuilder builder)
    {
        Builder = builder;
    }

    public void ConstructSedanCar()
    {
        Builder.SetVehicleType(VehicleType.SEDAN);
        Builder.SetEngine(new Engine(2500));
        Builder.SetSeats(5);
        Builder.SetTransmission(Transmission.AUTOMATIC);
    }

    public void ConstructSUV()
    {
        Builder.SetVehicleType(VehicleType.SUV);
        Builder.SetEngine(new Engine(2000));
        Builder.SetSeats(5);
        Builder.SetTransmission(Transmission.AUTOMATIC);
    }

    public void ConstructTruck()
    {
        Builder.SetVehicleType(VehicleType.TRUCK);
        Builder.SetEngine(new Engine(4000));
        Builder.SetSeats(2);
        Builder.SetTransmission(Transmission.MANUAL);
    }
}