using Builder.Vehicles;

namespace Builder.Builder;

public class CarBuilder : IVehicleBuilder<Car>
{
    private Car _car = new();

    public IVehicleBuilder<Car> Reset()
    {
        _car = new Car();
        return this;
    }

    public IVehicleBuilder<Car> SetWheels(ushort numOfWheels)
    {
        _car.NumberOfWheels = numOfWheels;
        return this;
    }

    public IVehicleBuilder<Car> SetDoors(ushort numOfDoors)
    {
        _car.NumberOfDoors = numOfDoors;
        return this;
    }

    public IVehicleBuilder<Car> SetSeats(ushort numOfSeats)
    {
        _car.NumberOfSeats = numOfSeats;
        return this;
    }

    public IVehicleBuilder<Car> SetEngineType(string engineType)
    {
        _car.EngineType = engineType;
        return this;
    }

    public IVehicleBuilder<Car> SetColor(string color)
    {
        _car.Color = color;
        return this;
    }

    public IVehicleBuilder<Car> SetNitro(bool hasNitro)
    {
        _car.HasNitro = hasNitro;
        return this;
    }

    public IVehicleBuilder<Car> SetAerofoil(bool hasAerofoil)
    {
        _car.HasAerofoil = hasAerofoil;
        return this;
    }

    public Car Instantiate()
    {
        return _car;
    }
}