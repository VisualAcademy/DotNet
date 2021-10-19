// 조건이 같은지 다른지 확인하기
using System;

class IfElse
{
    static void Main()
    {
        const double PI = 3.14;

        if (PI == 3.14)
        {
            Console.WriteLine("PI는 3.14입니다.");        // 참일 때 실행
        }
        else
        {
            Console.WriteLine("PI는 3.14가 아닙니다.");   // 거짓일 때 실행
        }
    }
}
