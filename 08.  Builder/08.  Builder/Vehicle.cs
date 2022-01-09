public class Vehicle
{
    public VehicleType VehicleType { get; set; }
    public int Seats { get; set; }
    public Engine Engine { get; set; }
    public Transmission Transmission { get; set; }

    public override string ToString()
    {
        return "VehicleType: " + VehicleType + ", Seats: " + Seats + ", Engine: " + Engine.Power + ", Transmission: " + Transmission;
    }
}