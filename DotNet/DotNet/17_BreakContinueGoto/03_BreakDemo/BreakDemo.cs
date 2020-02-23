using System;

class BreakDemo
{
    static void Main()
    {
        // break 문: for, while, do 구문을 빠져나가는 역할
        for (int i = 0; i < 100; i++)
        {
            if (i == 5)
            {
                break; // i == 5일 때 for문 종료
            }
            Console.Write($"{(i + 1)}번 반복\t");
        }
        Console.WriteLine();
    }
}

