using System;

class Program
{
    static void Main()
    {
        Stack<string> numbers = new();
        numbers.Push("one");
        numbers.Push("two");
        numbers.Push("three");
        numbers.Push("four");
        numbers.Push("five");

        Console.WriteLine($"numbers\n{numbers}");

        var numbers2 = numbers.Reverse();

        Console.WriteLine($"numbers2\n{numbers2}");
        Console.WriteLine($"numbers\n{numbers}");
        Console.WriteLine($"numbers isEmpty: {numbers.IsEmpty()}");
        Console.WriteLine($"numbers2 isEmpty: {numbers2.IsEmpty()}");

        var num = new Stack<int>();
        num.Push(1);
        num.Push(2);
        num.Push(3);
        num.Push(4);
        num.Push(5);
        num.Push(6);
        num.Push(7);
        num.Push(-2);
        num.Push(-5);
        num.Push(19);

        Console.WriteLine($"num isEmpty: {num.IsEmpty()}");
        Console.WriteLine($"num:\n{num}");

        var num2 = num.Reverse();

        Console.WriteLine($"num2:\n{num2}");

        Console.WriteLine($"num2 pop {num2.Pop()}");
        Console.WriteLine($"num2 pop {num2.Pop()}");

        num2.Push(0);

        Console.WriteLine($"num\n{num}");
        Console.WriteLine($"num2:\n{num2}");

    }
}