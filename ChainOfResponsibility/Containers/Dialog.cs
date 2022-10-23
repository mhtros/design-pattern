namespace ChainOfResponsibility.Containers;

public class Dialog : Container
{
    private readonly string? _wikiPageUrl;

    public Dialog(Container? parent = null, string? wikiPageUrl = null) : base(parent)
    {
        _wikiPageUrl = wikiPageUrl;
    }

    public override void ShowHelp()
    {
        if (_wikiPageUrl is not null) Console.WriteLine(_wikiPageUrl);
        if (BubbleUp) Parent?.ShowHelp();
    }
}