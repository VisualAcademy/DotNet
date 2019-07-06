using System;
using System.Linq;

class LinqFromWhereSelect
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        // arr 배열에서 짝수 데이터만 배열로 가져오기
        var q =
            from a in arr
            where a % 2 == 0
            select a;
        foreach (var i in q)
        {
            Console.WriteLine($"{i}"); // 2, 4
        }
    }
}
