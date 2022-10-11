using Adapter.Pegs;

namespace Adapter;

public sealed class RoundHole
{
    public RoundHole(int radius)
    {
        Radius = radius;
    }

    public int Radius { get; }

    public bool Fits(ICircularPeg peg)
    {
        return Radius >= peg.Radius;
    }
}