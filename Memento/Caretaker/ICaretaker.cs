namespace Memento.Caretaker;

public interface ICaretaker<TOriginator, TMemento>
{
    public TOriginator Originator { get; init; }
    public List<TMemento> History { get; init; }
    public void ToHistory(TMemento memento);
    public void Undo();
    public void Redo();
}