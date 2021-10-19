// if 문으로 한번에 여러 개의 조건을 처리하기
using System;

class IfAnd
{
    static void Main()
    {
        int number = 1_234;

        //[A] 2개의 조건이 모두 만족하면
        if (number == 1_234 && number >= 1_000)
        {
            Console.WriteLine("맞습니다.");             // 실행
        }

        //[B] 2개의 조건 중 하나라도 만족하면
        if (number == 1_234 || number <= 1_000)
        {
            Console.WriteLine("하나라도 참이면 참");    // 실행
        }
    }
}
