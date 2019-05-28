//[?] continue 문을 사용하여 반복문(for, while, do)에서 다음 반복으로 이동하기
using System;

class ForIfContinue
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            if (i % 2 == 0)
            {
                // 현재 반복 중지 후 다음 반복으로 이동
                continue; // 짝수 건너뛰기
            }
            Console.WriteLine(i); // 1, 3, 5
        }
    }
}
