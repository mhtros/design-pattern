namespace Adapter.Pegs;

public class RoundPeg : ICircularPeg
{
    public RoundPeg(int radius)
    {
        Radius = radius;
    }

    public virtual int Radius { get; }
}