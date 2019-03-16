using System;
using System.Collections.Generic;
using System.Linq;

class LinqSumEven
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3 };

        int sum = numbers.Where(number => number % 2 == 0).Sum(); 

        Console.WriteLine($"{nameof(numbers)} 배열 요소 중 짝수의 합: {sum}");
    }
}
