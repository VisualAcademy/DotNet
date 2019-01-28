// 확장 메서드 체이닝
using System;
using System.Collections.Generic;
using System.Linq;

class LinqChaining
{
    static void Main()
    {
        List<string> names = new List<string> { ".NET", "C#", "TypeScript" };

        // 체이닝: 확장 메서드를 여러 개 사용
        var results = names.Where(name => name.Length > 2).OrderBy(n => n);

        foreach (var name in results)
        {
            Console.WriteLine(name);
        }
    }
}
