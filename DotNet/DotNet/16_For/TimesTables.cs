using System;

class TimesTables
{
    static void Main()
    {
        // 행 반복: 1~9
        for (int i = 1; i <= 9; i++)
        {
            // 열 반복: 2~9
            for (int j = 2; j <= 9; j++)
            {
                Console.Write($"{j} x {i} = {j * i,2}  ");
            }
            Console.WriteLine();
        }
    }
}
