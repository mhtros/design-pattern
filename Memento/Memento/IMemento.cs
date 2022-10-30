namespace Memento.Memento;

public interface IMemento<T>
{
    T State { get; init; }
}