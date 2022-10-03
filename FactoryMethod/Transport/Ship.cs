namespace FactoryMethod.Transport;

public sealed class Ship : ITransport
{
    public string Deliver()
    {
        return "Ship: splash splash delivery!";
    }
}