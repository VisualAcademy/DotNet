using System;
using System.Collections.Generic;
using System.Linq;

class LinqWhereToList
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        List<int> newNumbers = numbers.Where(number => number > 3).ToList();

        foreach (var number in newNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
