using Observer.Interfaces.Info;

namespace Observer.Interfaces.Observer;

public class MagazineBuyer : IObserver<MagazineInfo> // aka Observer aka Subscriber.
{
    private readonly string _name;
    private IDisposable? _cancellation;

    private int _totalIssues;
    private decimal _totalSpendMoney;

    public MagazineBuyer(string name)
    {
        _name = name;
    }

    public void OnCompleted()
    {
        Console.WriteLine($"{_name} has spend a total {_totalSpendMoney:N} in {_totalIssues} issues.");
    }

    public void OnError(Exception error)
    {
        // No implementation.
    }

    public void OnNext(MagazineInfo value)
    {
        _totalSpendMoney += value.Price;
        _totalIssues++;

        Console.WriteLine($"{_name} has buy {value.Name} issue {value.Issue} for {value.Price:N}.");
    }

    public void Subscribe(IObservable<MagazineInfo> provider)
    {
        _cancellation = provider.Subscribe(this);
    }

    public void Unsubscribe()
    {
        Console.WriteLine($"{_name} don't want to spent any more money...");
        _cancellation?.Dispose();
        _totalIssues = 0;
        _totalSpendMoney = 0;
    }
}