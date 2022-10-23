using ChainOfResponsibility.Components;

namespace ChainOfResponsibility.Containers;

public abstract class Container : Component
{
    public Component? Children { get; set; } = null;

    protected Container(Container? parent) : base(parent)
    {
    }
}