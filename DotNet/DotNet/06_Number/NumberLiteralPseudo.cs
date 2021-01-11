//[?] 숫자(정수, 실수) 리터럴 접미사(L(l), F(f), ...)
using System;

class NumberLiteralPseudo
{
    static void Main()
    {
        int i = 1234; // 16비트 정수
        long l = 1234L; // 32비트 정수
        float f = 3.14f; // 단정밀도 실수
        double d = 3.14; // 배정밀도 실수
        decimal m = 12.34m; // 10진수 부동 소수점 숫자 

        Console.WriteLine(i);
        Console.WriteLine(l);
        Console.WriteLine(f);
        Console.WriteLine(d);
        Console.WriteLine(m);
    }
}
