using Adapter.Pegs;

namespace Adapter;

public sealed class SquarePegAdapter : RoundPeg
{
    public SquarePegAdapter(ISquarePeg peg) : base((int) (peg.Width * Math.Sqrt(2) / 2))
    {
    }
}