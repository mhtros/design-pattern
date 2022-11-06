namespace Observer.Event;

public class Button
{
    public event EventHandler<EventArgs>? OnClickHandler;

    public void Click()
    {
        OnClickHandler?.Invoke(this, EventArgs.Empty);
    }
}