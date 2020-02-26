using System;
using System.Linq;

class LinqOrderByDescendingEven
{
    static void Main()
    {
        var numbers = Enumerable.Range(11, 10);

        var sortedEvenNumbers = numbers.Where(n => n % 2 == 0).OrderByDescending(n => n);

        foreach (var item in sortedEvenNumbers)
        {
            Console.WriteLine(item);
        }
    }
}
