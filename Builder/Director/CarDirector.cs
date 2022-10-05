using Builder.Builder;
using Builder.Vehicles;

namespace Builder.Director;

public class CarDirector : IVehicleDirector<Car>
{
    private readonly IVehicleBuilder<Car> _builder;

    public CarDirector(IVehicleBuilder<Car> builder)
    {
        _builder = builder;
    }

    public Car CreateDefault()
    {
        return _builder.SetWheels(4).SetDoors(4).SetSeats(5).SetEngineType("V8").SetColor("Silver").Instantiate();
    }
}