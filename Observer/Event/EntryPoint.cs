namespace Observer.Event;

public static class EntryPoint
{
    public static void Start()
    {
        var clickCount = 0;
        var button = new Button();

        button.OnClickHandler += (_, _) => Console.WriteLine($"Button was clicked {++clickCount} time(s)");

        button.Click();
        button.Click();
    }
}