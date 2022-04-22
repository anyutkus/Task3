using System;

public static class IStackExtension
{
    public static Stack<T> Reverse<T>(this IStack<T> istack)
    {
        Stack<T> newStack = new();
        
        while(!istack.IsEmpty())
        {
            T newItem = istack.Pop();
            newStack.Push(newItem);
        }
        return newStack;
    }
}
