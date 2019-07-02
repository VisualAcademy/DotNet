using System;
using System.Collections.Generic;
using System.Linq;

class LinqForEach
{
    static void Main()
    {
        var numbers = new List<int>() { 10, 20, 30, 40, 50 };

        numbers.Where(n => n <= 20).ToList().ForEach(n => Console.WriteLine(n));
    }
}
