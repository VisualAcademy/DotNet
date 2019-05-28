// 구구단 출력하기 
using System;

class TimesTable
{
    static void Main()
    {
        for (int i = 2; i <= 9; i++)
        {
            Console.Write($"{i, 4}단  ");
        }
        Console.WriteLine();

        for (int i = 1; i <= 9; i++)        // 행(세로) 출력
        {
            for (int j = 2; j <= 9; j++)    // 열(가로) 출력
            {
                Console.Write($"{j}*{i}={j * i, 2}  "); // i와 j의 위치를 바꿔서 출력
            }
            Console.WriteLine();            // 1줄 출력 후 줄바꿈
        }
    }
}
