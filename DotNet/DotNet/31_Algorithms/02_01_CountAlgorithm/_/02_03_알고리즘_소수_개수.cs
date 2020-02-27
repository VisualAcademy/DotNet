//[?] 정수 하나 입력 받아서, 2부터 해당 수까지 안에 존재하는 모든 소수를 찾아서 출력
// 소수:
// - 자연수 중에서 1과 자기 자신만을 약수로 가지는 자연수
// - 5는 소수: 1과 5만을 약수로 가짐
// - 6은 소수가 아님: 1, 3, 6을 약수로 가짐
// - 2부터 해당 수까지 나머지값을 구해서 나머지값이 0일때 해당 수라면 소수
//      
using System;

class 알고리즘_소수_개수
{
    static void Main(string[] args)
    {
        int cnt = 0; // 소수 개수
        int num = 0; // 2~num까지의 수 중 소수를 구함
        bool sw = true; // 소수(true)

        Console.Write("수 입력: _\b");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i <= num; i++) // 2부터 n까지 반복하면서 소수 판별
        {
            sw = true; // 일단 모든 반복마다 소수로 놓고 시작
            // 2부터 현재수(i) - 1까지 나누었을 때 나누어 떨어지면 소수가 아님
            for (int j = 2; j < i; j++) 
            {
                if (i % j == 0)
                {
                    sw = false;
                    break;
                }
            }

            if (sw)
            {
                Console.Write("{0}\t", i);
                cnt++;

                // 줄바꿈
                if (cnt % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        Console.WriteLine("\n2부터 {0}까지의 소수의 개수: {1}", num, cnt);
    }
}
