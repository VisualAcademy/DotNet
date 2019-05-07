// continue 문을 사용하여 1부터 100까지 정수 중 7의 배수를 제외한 수들의 합계를 구하는 프로그램 
using System;

class ContinueExam
{
    static void Main()
    {
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            // 7의 배수 제외
            if (i % 7 == 0)
            {
                continue;
            }
            sum += i;
        }
        Console.WriteLine(sum); // 4315
    }
}
