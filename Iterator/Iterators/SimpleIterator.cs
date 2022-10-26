using Iterator.Collections;

namespace Iterator.Iterators;

public class SimpleIterator<T> : IIterator<T>
{
    private readonly IIterableCollection<T> _collection;
    private int _iterationState = -1;

    public SimpleIterator(IIterableCollection<T> collection)
    {
        _collection = collection;
    }

    public T GetNext()
    {
        return _collection.GetByIndex(_iterationState);
    }

    public bool HasMore()
    {
        if (_iterationState >= _collection.Length - 1)
        {
            Reset();
            return false;
        }

        _iterationState++;
        return true;
    }

    private void Reset()
    {
        _iterationState = -1;
    }
}