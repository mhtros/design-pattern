namespace Memento.Memento;

public record Memento<T>(T State) : IMemento<T>;