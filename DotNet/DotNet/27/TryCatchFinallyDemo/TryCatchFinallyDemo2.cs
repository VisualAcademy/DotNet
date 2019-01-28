using System;

class TryCatchFinallyDemo2
{
    static void Main()
    {
        int x = 5;
        int y = 0;
        int r;

        r = x / y; // 0으로 나누기 시도

        Console.WriteLine($"{x} / {y} = {r}");
    }
}
