using FactoryMethod.Transport;

namespace FactoryMethod.Logistics;

public sealed class SeaLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}