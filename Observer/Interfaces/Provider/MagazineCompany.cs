using Observer.Interfaces.Info;

namespace Observer.Interfaces.Provider;

public class MagazineCompany : IObservable<MagazineInfo> // aka Subject aka Provider
{
    private readonly List<IObserver<MagazineInfo>> _subscribers = new();

    public IDisposable Subscribe(IObserver<MagazineInfo> subscriber)
    {
        // Check whether observer is already registered. If not, add it`
        if (!_subscribers.Contains(subscriber)) _subscribers.Add(subscriber);
        return new Unsubscriber<MagazineInfo>(_subscribers, subscriber);
    }

    public void MagazineRelease(MagazineInfo magazineInfo)
    {
        if (_subscribers.Count == 0) return;

        // There will be no more issues
        if (magazineInfo.NextIssue is null)
        {
            foreach (var subscriber in _subscribers)
                subscriber.OnCompleted();

            _subscribers.Clear();
            return;
        }

        foreach (var subscriber in _subscribers)
            subscriber.OnNext(magazineInfo);
    }
}