using ChainOfResponsibility.Containers;

namespace ChainOfResponsibility.Components;

public abstract class Component : IContextualHelp
{
    protected readonly Container? Parent;

    protected Component(Container? parent)
    {
        Parent = parent;
    }

    public string? Tooltip { get; set; }

    public bool BubbleUp { get; set; } = true;

    public virtual void ShowHelp()
    {
        if (Tooltip is not null) Console.WriteLine(Tooltip);
        if (BubbleUp) Parent?.ShowHelp();
    }
}