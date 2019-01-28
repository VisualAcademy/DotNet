using System;

class MultipleParams
{
    static void Main()
    {
        Multi("A");
        Multi("A", "B");
        Multi("A", "B", "C");
    }

    static void Multi(params string[] messages)
    {
        foreach (string message in messages)
        {
            Console.Write(message);
        }
        Console.WriteLine();
    }
}
