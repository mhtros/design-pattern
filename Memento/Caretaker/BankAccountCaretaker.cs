using Memento.Memento;
using Memento.Originator;

namespace Memento.Caretaker;

public class BankAccountCaretaker : ICaretaker<BankAccount, BankAccountMemento>
{
    private int _current = -1;

    public BankAccountCaretaker(BankAccount originator)
    {
        Originator = originator;
        History.Add(new BankAccountMemento(originator.Balance));
        _current++;
    }

    public BankAccount Originator { get; init; }
    public List<BankAccountMemento> History { get; init; } = new();

    public void ToHistory(BankAccountMemento memento)
    {
        History.Add(memento);
        _current++;
    }

    public void Undo()
    {
        var m = _current == 0 ? History.First() : History[--_current];
        Originator.Restore(m);
    }

    public void Redo()
    {
        var m = _current == History.Count - 1 ? History.Last() : History[++_current];
        Originator.Restore(m);
    }
}