using System;
using System.Linq;

class AggregateMethod
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3 };

        // 초깃값이 0으로 설정된 경우
        int sumWithSeed = numbers.Aggregate(0, (accumulator, current) => accumulator + current);

        // 초깃값이 생략된 경우 (첫 번째 요소가 초깃값이 됨)
        int sumWithoutSeed = numbers.Aggregate((accumulator, current) => accumulator + current);

        Console.WriteLine($"Sum with seed (0): {sumWithSeed}"); // 6
        Console.WriteLine($"Sum without seed: {sumWithoutSeed}"); // 6
    }
}
