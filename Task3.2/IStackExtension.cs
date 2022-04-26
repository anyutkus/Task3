using System;

public static class IStackExtension
{
    public static Stack<T> Reverse<T>(this IStack<T> istack)
    {
        Stack<T> newStack = new();
        var stackCopy = istack.Copy();
       
        while(!stackCopy.IsEmpty())
        {
            T newItem = stackCopy.Pop();
            newStack.Push(newItem);
        }
        return newStack;
    }

    public static Stack<T> Copy<T>(this IStack<T> stack)
    {
        var arr = stack.GetItems;
        var newStack = new Stack<T>();
        for (var i = 0; i < arr.Length; i++)
        {
            newStack.Push(arr[i]);
        }
        return newStack;
    }
}
