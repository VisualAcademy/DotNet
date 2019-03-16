using System;
using System.Collections.Generic;
using System.Linq;

class LinqMax
{
    static void Main()
    {
        var numbers = new List<int>() { 1, 2, 3 };

        int max = numbers.Max();

        Console.WriteLine($"{nameof(numbers)} 컬렉션의 최댓값: {max}");
    }
}
