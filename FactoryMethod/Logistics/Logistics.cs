using FactoryMethod.Transport;

namespace FactoryMethod.Logistics;

public abstract class Logistics
{
    public abstract ITransport CreateTransport();
}