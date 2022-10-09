using Adapter.Pegs;

namespace Adapter;

public sealed class RoundHole
{
    public int Radius { get; }

    public RoundHole(int radius)
    {
        Radius = radius;
    }

    public bool Fits(ICircularPeg peg)
    {
        return Radius >= peg.Radius;
    }
}