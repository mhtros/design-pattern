using FactoryMethod;
using FactoryMethod.Logistics;

var type = new Random().Next(0, 2); // zero or one

Logistics? logistics = type switch
{
    (int) TransportType.Road => new RoadLogistics(),
    (int) TransportType.Ship => new SeaLogistics(),
    _ => null
};

var transport = logistics?.CreateTransport();
Console.WriteLine(transport?.Deliver());