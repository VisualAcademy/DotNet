using System;

class ForDemo
{
    static void Main()
    {
        //[1] 1부터 5까지 3개씩 출력하는 프로그램
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("{0}\t", i);
            if (i % 3 == 0)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();

        //[2] 1~100까지 정수의 합을 구하는 프로그램
        int sum1 = 0; // 합을 저장할 변수
        for (int i = 1; i <= 100; i++)
        {
            sum1 += i; // 누적
        }
        Console.WriteLine($"1부터 100까지의 합 : {sum1}");

        //[3] 1~100까지 정수 중 짝수의 합을 구하는 프로그램
        int sum2 = 0;
        for (int i = 1; i <= 100; ++i)
        {
            if (i % 2 == 0)
            {
                sum2 += i; // 짝수만...
            }
        }
        Console.WriteLine($"1부터 100까지의 짝수의 합 : {sum2}");
    }
}
