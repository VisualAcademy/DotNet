// 재귀(Recursion)를 사용한 2 ^ n 승 패턴 구하기
using System;

class RecursionPower
{
    static int MyPower(int num, int cnt)
    {
        if (cnt == 0)
        {
            return 1;
        }
        return num * MyPower(num, --cnt); // 2 * (2 * (1))
    }

    static void Main()
    {
        Console.WriteLine(MyPower(2, 2)); // 2 * 2 * 1 = 4
    }
}
