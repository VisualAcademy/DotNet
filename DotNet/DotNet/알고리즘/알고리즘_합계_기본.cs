//[?] 1부터 100까지 정수의 합을 구하는 프로그램
using System;

class 알고리즘_합계_기본
{
    static void Main(string[] args)
    {
        int SUM = 0;

        int N = 1; // 1 ~ 100

        do
        {
            SUM = SUM + N;
            N = N + 1; 
        } while (N <= 100);

        Console.WriteLine(SUM);
    }
}
