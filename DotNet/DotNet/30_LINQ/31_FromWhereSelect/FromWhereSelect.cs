// LINQ(Language INtegrated Query)
using System;
using System.Linq;

class FromWhereSelect
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        var evenNumbers =
            from num in arr
            where num % 2 == 0
            select num;

        foreach (var number in evenNumbers)
        {
            Console.WriteLine($"짝수: {number}");
        }
    }
}
