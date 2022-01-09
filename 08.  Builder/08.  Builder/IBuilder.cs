public interface IBuilder
{
    public void Reset();
    public Vehicle GetVehicle();
    public void SetSeats(int seats);
    public void SetEngine(Engine engine);
    public void SetTransmission(Transmission transmission);
    public void SetVehicleType(VehicleType vehicleType);
}