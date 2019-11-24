using System;
using System.Linq;

class AggregateDemo
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        //[1] Aggregate 확장 메서드로 최댓값 구하기
        int max = numbers.Aggregate((f, s) => f > s ? f : s);
        Console.WriteLine(max);

        //[2] Aggregate 확장 메서드로 최솟값 구하기
        int min = numbers.Aggregate((c, n) => c < n ? c : n);
        Console.WriteLine(min);
    }
}
