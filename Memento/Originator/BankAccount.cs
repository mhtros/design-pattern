using Memento.Caretaker;
using Memento.Memento;

namespace Memento.Originator;

public class BankAccount : IOriginator<BankAccountMemento>
{
    private readonly BankAccountCaretaker _caretaker;

    public BankAccount(decimal? startBalance = null)
    {
        _caretaker = new BankAccountCaretaker(this);
        Balance = startBalance ?? 0;
    }

    public decimal Balance { get; private set; }

    public void Restore(BankAccountMemento bankAccountMemento)
    {
        Balance = bankAccountMemento.State;
    }

    public void Withdraw(decimal amount)
    {
        if (Balance >= amount) Balance -= amount;
        else throw new Exception("Insufficient balance.");

        _caretaker.ToHistory(new BankAccountMemento(Balance));
    }

    public void Deposit(decimal amount)
    {
        Balance += Math.Abs(amount);
        _caretaker.ToHistory(new BankAccountMemento(Balance));
    }

    public override string ToString() => $"Balance: {Balance}";

    public void Undo() => _caretaker.Undo();

    public void Redo() => _caretaker.Redo();
}