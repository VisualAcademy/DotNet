// 1부터 100까지 짝수의 합을 구하는 프로그램
using System;

namespace 제어문_짝수의합
{
    class 제어문_짝수의합
    {
        static void Main(string[] args)
        {
            //[1] Input
            int sum = 0;

            //[2] Process : 주어진 범위(for문)에 주어진 조건(if문)
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i; // 짝수일 때만 합
                }
            }

            //[3] Output
            Console.WriteLine("1부터 100까지 짝수의 합: {0}", sum);
        }
    }
}
