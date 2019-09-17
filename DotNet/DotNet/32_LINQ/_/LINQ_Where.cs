using System;
using System.Collections.Generic;
using System.Linq;

class LINQ_Where
{
    static void Main()
    {
        List<string> names = new List<string> { "Angular", "Bootstrap", "C#" };

        IEnumerable<string> search = names.Where(n => n.Contains("a"));

        foreach (var name in search)
        {
            Console.WriteLine("찾은 결과: " + name);
        }
    }
}
