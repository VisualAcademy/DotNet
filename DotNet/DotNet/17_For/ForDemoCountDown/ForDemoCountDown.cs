using System;

class ForDemoCountDown
{
    static void Main()
    {
        //[1] i 변수의 값이 0, 1, 2, 3, 4로 증가
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{i + 1}\t"); // 탭(\t)으로 간격 띄우기 
        }
        Console.WriteLine();

        //[2] i 변수의 값이 5, 4, 3, 2, 1로 감소
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"{i}\t");
        }
        Console.WriteLine();
    }
}
