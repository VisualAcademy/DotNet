using System;

class NumberMaxMin
{
    static void Main()
    {
        Console.WriteLine("[08비트] sbyte 최솟값: {0}", sbyte.MinValue);
        Console.WriteLine("[08비트] sbyte 최댓값: {0}", sbyte.MaxValue);

        Console.WriteLine("[16비트] short 최솟값: {0}", short.MinValue);
        Console.WriteLine("[16비트] short 최댓값: {0}", short.MaxValue);

        Console.WriteLine("[32비트] int 최솟값: {0}", int.MinValue);
        Console.WriteLine("[32비트] int 최댓값: {0}", int.MaxValue);

        Console.WriteLine("[64비트] long 최솟값: {0}", long.MinValue);
        Console.WriteLine("[64비트] long 최댓값: {0}", long.MaxValue);
    }
}
