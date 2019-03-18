// using static 지시문: C# 6.0의 새로운 기능
using System;
using static System.Console;
using static System.Math;

class UsingStaticClassesDemo
{
    static void Main()
    {
        //[1] 기본 사용 방식
        WriteLine(Math.Pow(2, 10));

        //[2] using static 지시문에 의한 줄임 표현
        WriteLine(Pow(2, 10));
        WriteLine(Max(3, 5));
    }
}
