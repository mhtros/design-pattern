using FactoryMethod.Transport;

namespace FactoryMethod.Logistics;

public sealed class RoadLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Truck();
    }
}