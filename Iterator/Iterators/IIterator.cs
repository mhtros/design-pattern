namespace Iterator.Iterators;

public interface IIterator<out T>
{
    public T GetNext();
    public bool HasMore();
}