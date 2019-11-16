using System;

class Dynamic
{
    static void Main()
    {
        dynamic x;

        x = 1234; // [1] int
        Console.WriteLine(x); // 1234
        Console.WriteLine(x.GetType()); // System.Int32

        x = "Dynamic Type!"; // [2] string
        Console.WriteLine(x); // "Dynamic Type!"
        Console.WriteLine(x.GetType()); // System.String
    }
}
