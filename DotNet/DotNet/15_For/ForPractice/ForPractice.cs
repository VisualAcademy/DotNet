// 연습문제: 1부터 10까지 정수 중 3의 배수만 출력하는 프로그램
using System;

class ForPractice
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
