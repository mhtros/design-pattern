﻿using Iterator.Collections;

namespace Iterator.Iterators;

public class BackAndForthAlternatelyIterator<T> : IIterator<T>
{
    private readonly IIterableCollection<T> _collection;
    private int _end;
    private bool _getFromStart;
    private int _start;

    public BackAndForthAlternatelyIterator(IIterableCollection<T> collection)
    {
        _collection = collection;
        Reset();
    }

    public T GetNext()
    {
        if (_getFromStart)
        {
            var fromStart = _collection.GetByIndex(_start);
            _start++;
            _getFromStart = false;
            return fromStart;
        }

        var fromEnd = _collection.GetByIndex(_end);
        _end--;
        _getFromStart = true;
        return fromEnd;
    }

    public bool HasMore()
    {
        return _start <= _end;
    }

    private void Reset()
    {
        _getFromStart = true;
        _start = 0;
        _end = _collection.Length - 1;
    }
}