namespace ChainOfResponsibility.Containers;

public class Panel : Container
{
    private readonly string? _modalHelpText;

    public Panel(Container? parent = null, string? modalHelpText = null) : base(parent)
    {
        _modalHelpText = modalHelpText;
    }

    public override void ShowHelp()
    {
        if (_modalHelpText is not null) Console.WriteLine(_modalHelpText);
        if (BubbleUp) Parent?.ShowHelp();
    }
}