using System;

public class 구구단_가로출력
{
    static void Main(string[] args)
    {
        for (int i = 2; i <= 9; i++)
        {
            Console.Write(" {0,-5} ", i.ToString() + "단");
        }
        Console.WriteLine();
        for (int i = 1; i <= 9; i++)        // 행(세로) 출력
        {
            for (int j = 2; j <= 9; j++)    // 열(가로) 출력
            {
                Console.Write("{0}*{1}={2,2}  ", j, i, (j * i));
            }
            Console.WriteLine();            // 1줄 출력 후 줄바꿈
        }
        Console.Read();
    }
}
