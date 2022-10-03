namespace FactoryMethod.Transport;

public sealed class Truck : ITransport
{
    public string Deliver()
    {
        return "Truck: vroom vroom delivery!";
    }
}