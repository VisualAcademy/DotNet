using System;
using System.Linq;

class EnumerableDemo
{
    static void Main()
    {
        // 1부터 5까지
        var numbers = Enumerable.Range(1, 5);
        foreach (var n in numbers)
            Console.Write("{0}\t", n);
        Console.WriteLine();

        // -1을 5개
        var sameNumbers = Enumerable.Repeat(-1, 5);
        foreach (var n in sameNumbers)
            Console.Write("{0}\t", n);
        Console.WriteLine();
    }
}
