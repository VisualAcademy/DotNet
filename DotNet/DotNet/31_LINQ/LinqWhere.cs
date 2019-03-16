using System;
using System.Collections.Generic;
using System.Linq;

class LinqWhere
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        IEnumerable<int> newNumbers = numbers.Where(number => number > 3);

        foreach (var n in newNumbers)
        {
            Console.WriteLine(n);
        }
    }
}
