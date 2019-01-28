using System;

enum Priority
{
    High,
    Normal,
    Low
}

class EnumerationDemo
{
    static void Main()
    {
        Priority high = Priority.High;
        Priority normal = Priority.Normal;
        Priority low = Priority.Low;

        Console.WriteLine("{0}, {1}, {2}", high, normal, low);
    }
}
