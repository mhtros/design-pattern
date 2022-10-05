namespace Builder.Builder;

public interface IVehicleBuilder<out T> where T : class
{
    public IVehicleBuilder<T> Reset();
    public IVehicleBuilder<T> SetWheels(ushort numOfWheels);
    public IVehicleBuilder<T> SetDoors(ushort numOfDoors);
    public IVehicleBuilder<T> SetSeats(ushort numOfSeats);
    public IVehicleBuilder<T> SetEngineType(string engineType);
    public IVehicleBuilder<T> SetColor(string color);
    public IVehicleBuilder<T> SetNitro(bool hasNitro);
    public IVehicleBuilder<T> SetAerofoil(bool hasAerofoil);
    public T Instantiate();
}