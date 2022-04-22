using System;

public class Stack<T> : IStack<T>
{
    const int MaxAmount = 50;
    private T[] _elements = new T[MaxAmount];
    private int _index = -1;

    public void Push(T e)
    {
        _index++;
        _elements[_index] = e;
    }

    public T Pop()
    {
        if(_index >= 0)
        {
            var lastElement = _elements[_index];
            _elements[_index] = default;
            _index--;

            return lastElement;
        }
        else
        {
            return default;
        }
    }

    public bool IsEmpty()
    {
        return _index < 0;
    }

    public override string ToString()
    {
        var str = "";
        for (var i = 0; i <= _index; i++)
        {
            str += _elements[i].ToString() + "\n";
        }

        return str;
    }
}