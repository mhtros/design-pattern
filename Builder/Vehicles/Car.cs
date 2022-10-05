using System.Text.Json;

namespace Builder.Vehicles;

public sealed class Car : IVehicle
{
    public ushort NumberOfWheels { get; set; }
    public ushort NumberOfDoors { get; set; }
    public ushort NumberOfSeats { get; set; }
    public string EngineType { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public bool HasNitro { get; set; }
    public bool HasAerofoil { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}