using System;

/// <summary>
/// 등차수열(Arithmetic Sequence): 연속하는 두 수의 차이가 일정한 수열
/// 예) 1부터 100까지의 합: 5050
/// 100 * (1 + 100) / 2
/// 100 * (2 * 1 + (100 - 1) * 1) / 2
/// </summary>
class ArithmeticSequenceSum
{
    static void Main()
    {
        var sum = 0;

        for (int i = 1; i <= 100; i++)
        {
            sum += i;
        }

        Console.WriteLine(sum);
    }
}
