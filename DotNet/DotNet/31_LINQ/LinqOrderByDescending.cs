using System;
using System.Collections.Generic;
using System.Linq;

class LinqOrderByDescending
{
    static void Main()
    {
        var colors = new List<string> { "Red", "Blue", "Green" };

        var sortedColors = colors.OrderByDescending(c => c);

        foreach (var color in sortedColors)
        {
            Console.WriteLine(color);
        }
    }
}
