using Iterator.Iterators;

namespace Iterator.Collections;

public class IterableList<T> : IIterableCollection<T>
{
    private readonly Lazy<List<T>> _internalCollection = new(() => new List<T>());
    private readonly Type _iteratorType;

    public IterableList(Type iteratorType, params T[]? initialValues)
    {
        _iteratorType = iteratorType;
        if (initialValues is not null && initialValues.Any()) _internalCollection.Value.AddRange(initialValues);
    }

    public int Length => _internalCollection.Value.Count;

    public T GetByIndex(int index)
    {
        return _internalCollection.Value.ElementAt(index);
    }

    public IIterator<T> CreateIterator()
    {
        if (!_iteratorType.GetInterfaces().Contains(typeof(IIterator<T>)))
        {
            var msg = $"Iterator type {_iteratorType} not compatible with type {typeof(IIterator<T>)}";
            throw new Exception(msg);
        }

        var instance = Activator.CreateInstance(_iteratorType, this);
        if (instance is null) throw new NullReferenceException();
        return (IIterator<T>) instance;
    }

    public void Add(T item)
    {
        _internalCollection.Value.Add(item);
    }

    public void Remove(T item)
    {
        _internalCollection.Value.Remove(item);
    }
}