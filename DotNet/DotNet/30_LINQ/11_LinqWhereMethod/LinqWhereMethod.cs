using System;
using System.Linq;

class LinqWhereMethod
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        // 배열에서 홀수만 추출: 람다 식 사용
        var q = arr.Where(num => num % 2 == 1);

        foreach (var n in q)
        {
            Console.WriteLine(n); // 1, 3, 5
        }
    }
}
