using System;
using System.Linq;

class LinqOrderByEven
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 10);

        var sortedEvenNumbers = numbers.Where(n => n % 2 == 0).OrderBy(n => n);

        foreach (var item in sortedEvenNumbers)
        {
            Console.WriteLine(item);
        }
    }
}
