// continue문: 반복문에서 아래 실행문을 실행하지 않고 다음 구문으로 이동
using System;

class ContinueDemo
{
    static void Main()
    {
        //[!] 1~100까지 정수 중 3의 배수를 제외한 수의 합
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                continue; // 3의 배수이면 [i++] 코드 영역으로 이동하기 
            }
            sum += i;
        }
        Console.WriteLine("SUM: {0}", sum); // 3367
    }
}
