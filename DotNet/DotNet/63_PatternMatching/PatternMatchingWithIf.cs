using System;
using static System.Console;

class PatternMatchingWithIf
{
    static void Main()
    {
        PrintStars(null);
        PrintStars("하나");
        PrintStars(5);
    }

    static void PrintStars(object o)
    {
        if (o is null)
        {
            return; // null 제외
        }

        if (o is string)
        {
            return; // 문자열 제외
        }

        // 패턴 매칭: 넘어온 값이 정수 형식이면 int number = o;
        if (!(o is int number))
        {
            return; // 정수형 이외의 값 제외
        }
        WriteLine(new String('*', number));
    }
}
