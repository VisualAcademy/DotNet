using System;
using System.Collections.Generic;
using System.Linq;

class LinqWhereContains
{
    static void Main()
    {
        List<string> names = new List<string> { "ASP.NET", "Blazor", "C#" };

        IEnumerable<string> search = names.Where(n => n.Contains("a"));

        foreach (var name in search)
        {
            Console.WriteLine("찾은 결과: " + name);
        }
    }
}
