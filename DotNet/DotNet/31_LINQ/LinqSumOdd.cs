using System;
using System.Collections.Generic;
using System.Linq;

class LinqSumOdd
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3 };

        int sum = numbers.Where(n => n % 2 == 1).Sum();

        Console.WriteLine($"{nameof(numbers)} 배열 요소 중 홀수의 합: {sum}");
    }
}
