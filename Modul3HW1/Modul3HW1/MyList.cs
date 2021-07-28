using System;
using System.Collections.Generic;
public class MyList<T> // : IReadOnlyCollection <T>
{
    private int _arraySize = 0;
    private T[] _array;

    public MyList()
    {
        _array = new T[4];
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

    public void AddRange(T[] array)
    {
        foreach (var item in array)
        {
            Add(item);
        }
    }

    public void Remove(T item)
    {
        for (var index = 0; index < _array.Length; index++)
        {
            if (_array[index].Equals(item))
            {
                RemoveAt(index);
            }
        }
    }

    public void RemoveAt(int index)
    {
        _array[index] = default(T);
    }

    public void Sort(IComparer<T> comparer)
    {
        Array.Sort(_array, comparer);
    }

    public T[] GetArray()
    {
        return _array;
    }
}
