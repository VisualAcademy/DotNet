using System;
using System.Linq;

class LinqSum
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3 };

        int sum = numbers.Sum();

        Console.WriteLine($"numbers 배열 요소의 합: {sum}");
    }
}
