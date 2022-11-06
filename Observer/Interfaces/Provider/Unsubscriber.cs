namespace Observer.Interfaces.Provider;

public class Unsubscriber<T> : IDisposable
{
    private readonly IObserver<T> _subscriber;
    private readonly List<IObserver<T>> _subscribers;

    public Unsubscriber(List<IObserver<T>> subscribers, IObserver<T> subscriber)
    {
        _subscribers = subscribers;
        _subscriber = subscriber;
    }

    public void Dispose()
    {
        if (_subscribers.Contains(_subscriber))
            _subscribers.Remove(_subscriber);
    }
}