namespace Builder.Director;

public interface IVehicleDirector<out T> where T : class
{
    public T CreateDefault();
}