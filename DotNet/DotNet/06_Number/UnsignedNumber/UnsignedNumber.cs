using System;

class UnsignedNumber
{
    static void Main()
    {
        Console.WriteLine("[08비트] byte 최솟값: {0}", byte.MinValue);
        Console.WriteLine("[08비트] byte 최댓값: {0}", byte.MaxValue);

        Console.WriteLine("[16비트] ushort 최솟값: {0}", ushort.MinValue);
        Console.WriteLine("[16비트] ushort 최댓값: {0}", ushort.MaxValue);

        Console.WriteLine("[32비트] uint 최솟값: {0}", uint.MinValue);
        Console.WriteLine("[32비트] uint 최댓값: {0}", uint.MaxValue);

        Console.WriteLine("[64비트] ulong 최솟값: {0}", ulong.MinValue);
        Console.WriteLine("[64비트] ulong 최댓값: {0}", ulong.MaxValue);
    }
}
