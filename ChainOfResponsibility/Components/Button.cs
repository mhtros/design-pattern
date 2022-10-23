using ChainOfResponsibility.Containers;

namespace ChainOfResponsibility.Components;

public class Button : Component
{
    public Button(Container? parent) : base(parent)
    {
    }
}