//[?] 제어문: 조건반복(while문)
using System;

class 제어문_조건반복
{
    static void Main()
    {
        //[!] while문을 사용하여 짝수의 합
        int sum = 0;

        int i = 1;                  // 초기식
        while (i <= 100)            // 조건식
        {
            if (i % 2 == 0)         // 필터링(조건처리)
            {
                sum += i;           // 실행문 
            }
            i++;                    // 증감식
        }

        Console.WriteLine("{0}", sum);
    }
}
