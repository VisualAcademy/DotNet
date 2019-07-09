using System;
using System.Collections.Generic;

public class LambdaExpressionWithPredicate
{
    // 매개 변수로 람다 식을 받는 메서드
    static IEnumerable<int> FindNumbers(Predicate<int> predicate)
    {
        for (int i = 1; i <= 100; i++)
        {
            if (predicate(i))
            {
                yield return i; 
            }
        }
    }

    static void Main()
    {
        var numbers = FindNumbers(f => f % 33 == 0);
        foreach (var n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}
