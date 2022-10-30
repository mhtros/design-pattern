namespace Memento.Memento;

public record BankAccountMemento(decimal State) : Memento<decimal>(State);