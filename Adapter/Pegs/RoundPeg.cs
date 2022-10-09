namespace Adapter.Pegs;

public class RoundPeg : ICircularPeg
{
    public virtual int Radius { get; }

    public RoundPeg(int radius)
    {
        Radius = radius;
    }
}