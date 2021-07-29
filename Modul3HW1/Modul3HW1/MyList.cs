using System;
using System.Collections;
using System.Collections.Generic;

public class MyList<T> : IReadOnlyCollection<T>
{
    private int _arraySize = 0;
    private T[] _array;

    public MyList()
    {
        _array = new T[4];
    }

    public int Count => _arraySize;

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var i in _array)
        {
            yield return i;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        foreach (var i in _array)
        {
            yield return i;
        }
    }

    public void Add(T value)
    {
        if (_arraySize == _array.Length)
        {
            Array.Resize<T>(ref _array, _array.Length * 2);
        }

        _array[_arraySize] = value;
        _arraySize++;
    }

    public void AddRange(IEnumerable<T> array)
    {
        foreach (var item in array)
        {
            Add(item);
        }
    }

    public bool Remove(T item)
    {
        var isDeleted = false;

        for (var index = 0; index < _array.Length; index++)
        {
            if (_array[index].Equals(item))
            {
                RemoveAt(index);
                isDeleted = true;
            }
        }

        return isDeleted;
    }

    public void RemoveAt(int index)
    {
        _array[index] = default(T);
        _arraySize--;
    }

    public void Sort(IComparer<T> comparer)
    {
        Array.Sort(_array, comparer);
    }
}
