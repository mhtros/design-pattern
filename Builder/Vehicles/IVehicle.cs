namespace Builder.Vehicles;

public interface IVehicle
{
    public ushort NumberOfWheels { get; set; }
    public ushort NumberOfDoors { get; set; }
    public ushort NumberOfSeats { get; set; }
    public string EngineType { get; set; }
    public string Color { get; set; }
    public bool HasNitro { get; set; }
    public bool HasAerofoil { get; set; }
}