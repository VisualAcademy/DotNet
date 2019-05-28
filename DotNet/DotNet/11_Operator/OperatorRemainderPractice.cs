using System;

class OperatorRemainderPractice
{
    static void Main()
    {
        int x = 8;
        int y = 5;

        int s = x / y; // 몫
        int r = x % y; // 나머지

        Console.WriteLine($"{x} 나누기 {y} -> 몫: {s}, 나머지: {r}");
    }
}
