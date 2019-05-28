using System;

class WhileEven
{
    static void Main()
    {
        //[!] while 문을 사용하여 짝수의 합
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

        Console.WriteLine($"1부터 100까지 짝수의 합: {sum}");
    }
}
