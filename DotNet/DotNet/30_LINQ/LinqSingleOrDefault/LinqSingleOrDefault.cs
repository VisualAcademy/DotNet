using System;
using System.Collections.Generic;
using System.Linq;

class LinqSingleOrDefault
{
    static void Main()
    {
        List<string> names = new List<string>() {
            "C#", "ASP.NET", "TypeScript"
        };

        // 검색 조건이 맞는 데이터가 있는 경우
        string csharp = names.SingleOrDefault(name => name == "C#");
        Console.WriteLine(csharp);

        // 검색 조건이 맞는 데이터가 없는 경우
        string javascript = names.SingleOrDefault(n => n == "JavaScript");
        if (javascript == null)
        {
            Console.WriteLine("JavaScript 항목을 찾을 수 없습니다.");
        }
    }
}
