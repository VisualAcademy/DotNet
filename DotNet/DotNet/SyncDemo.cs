using System;

class SyncDemo
{
    static void Main()
    {
        Sum(3, 5);
        Sum(5, 7);
        Sum(7, 9);
    }

    static void Sum(int a, int b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }
}
