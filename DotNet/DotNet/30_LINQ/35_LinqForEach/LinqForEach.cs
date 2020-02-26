// ForEach() 확장 메서드를 사용하여 foreach 문을 LINQ 식에 포함하여 사용 가능
using System;
using System.Collections.Generic;
using System.Linq;

class LinqForEach
{
    static void Main()
    {
        var numbers = new List<int>() { 10, 20, 30, 40, 50 };

        numbers.Where(n => n <= 20).ToList().ForEach(n => Console.WriteLine(n));

        var names = new List<string>() { "RedPlus", "Taeyo" };

        names.ForEach(n => Console.WriteLine(n));
    }
}
