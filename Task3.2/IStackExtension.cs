using System;

public static class IStackExtension
{
    public static Stack<T> Reverse<T>(this IStack<T> istack)
    {
        Stack<T> newStack = new();
        
        while(!istack.IsEmpty())
        {
            T s = istack.Pop();
            newStack.Push(s);
        }
        return newStack;
    }
}
