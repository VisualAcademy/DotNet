//[?] 1부터 100까지 정수의 합계 구하기
using System;

class SeeSharpSum100
{
    static void Main()
    {
        //[1] Input(입력)
        int sum = 0;

        //[2] Process(처리)
        for (int i = 1; i <= 100; i++) // i가 1에서 100까지 100번 반복
        {
            sum += i; // sum = sum + i; // 누적(SUM)
        }

        //[3] Output(출력)
        Console.WriteLine("1부터 100까지 정수의 합: {0}",  sum); // 5050
    }
}
