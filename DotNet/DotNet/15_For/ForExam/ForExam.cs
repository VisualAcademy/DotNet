// 심사문제: 1부터 10까지 정수 중 짝수만 출력하는 프로그램
using System;

class ForExam
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
