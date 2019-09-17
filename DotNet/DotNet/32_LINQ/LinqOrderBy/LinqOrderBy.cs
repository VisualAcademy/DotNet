using System;
using System.Collections.Generic;
using System.Linq;

class LinqOrderBy
{
    static void Main()
    {
        string[] colors = { "Red", "Green", "Blue" };

        IEnumerable<string> sortedColors = colors.OrderBy(name => name);

        foreach (var color in sortedColors)
        {
            Console.WriteLine(color);
        }
    }
}
