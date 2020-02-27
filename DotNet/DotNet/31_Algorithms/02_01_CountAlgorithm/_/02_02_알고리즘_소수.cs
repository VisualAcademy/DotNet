//[?] 특정 수를 입력 받아서, 소수인지 아닌지 판별하는 프로그램
// 소수:
// - 자연수 중에서 1과 자기 자신만을 약수로 가지는 자연수
// - 5는 소수: 1과 5만을 약수로 가짐
// - 6은 소수가 아님: 1, 2, 3, 6을 약수로 가짐
// - 2부터 해당 수까지 나머지값을 구해서 나머지값이 0일때 해당 수라면 소수
using System;

class 알고리즘_소수
{
    static void Main()
    {
        int k = 1;
        int num = 0;
        Console.Write("수 입력: _\b");
        num = Convert.ToInt32(Console.ReadLine());

        // 2~num 까지 나누어 떨어지는 수가 발생할 때까지 반복.
        // 소수는 num로만 나누어 떨어짐
        do
        {
            k = k + 1;

            Console.WriteLine("{0} % {1} = {2}", num, k, num % k);
        } while (num % k != 0); 

        // 나누어 떨어졌을 때의 값이 입력된 수와 같다면,
        // 즉, 중간에 다른 수로 나누어 떨어지지 않았다면 소수.
        if (num == k) 
        {
            Console.WriteLine("소수임");
        }
        else
        {
            Console.WriteLine("소수 아님");
        }
    }
}
