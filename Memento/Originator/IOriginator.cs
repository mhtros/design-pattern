namespace Memento.Originator;

public interface IOriginator<in TMemento>
{
    public void Restore(TMemento memento);
}