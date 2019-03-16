using System;
using System.Linq;

class Filter
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Where() 확장 메서드를 사용한 필터링
        var nums = numbers.Where(it => it % 2 == 0 && it > 3); // 짝수 && 3보다 큰

        foreach (var num in nums)
        {
            Console.WriteLine(num);
        }
    }
}
