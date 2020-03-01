using System;
using System.Linq;

class LinqCount
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3 };

        int count = numbers.Count();

        Console.WriteLine($"{nameof(numbers)} 배열 개수: {count}");
    }
}
