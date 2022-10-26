using Iterator.Iterators;

namespace Iterator.Collections;

public interface IIterableCollection<out T>
{
    public int Length { get; }
    public IIterator<T> CreateIterator();

    public T GetByIndex(int index);
}