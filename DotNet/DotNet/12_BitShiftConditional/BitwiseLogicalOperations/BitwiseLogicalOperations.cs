using System;

class BitwiseLogicalOperations
{
    static void Main()
    {
        int x = 1;
        Console.WriteLine(!(x > 0));
        Console.WriteLine(x > 0 || x < 4);
        Console.WriteLine(x << 2);
        Console.WriteLine(x & 2);
        Console.WriteLine(x % 3);
    }
}
