namespace Proxy;

public class CarProxy : ICar
{
    private readonly Car _car = new();

    public CarProxy(Driver driver)
    {
        Driver = driver;
    }

    public Driver Driver { get; }

    public void Drive()
    {
        if (Driver.Age < 18) Console.WriteLine("To young to drive!");
        else _car.Drive();
    }
}