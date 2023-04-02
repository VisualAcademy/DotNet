//[?] 1부터 n까지 정수 중 짝수의 합을 구하는 프로그램
using System;

class ForSumEven
{
    static void Main()
    {
        int n = 5;
        int sum = 0;

        for (int i = 1; i <= n; i++) // n == 5이므로 i가 1, 2, 3, 4일 때
        {
            if (i % 2 == 0) // 모든 숫자를 2로 나누었을 때 0과 같으면 짝수 
            {
                sum += i; // 짝수만(2, 4) 덧셈 
            }
        }

        // 1부터 5까지 짝수의 합: 6
        Console.WriteLine($"1부터 {n}까지 짝수의 합: {sum}");
    }
}
