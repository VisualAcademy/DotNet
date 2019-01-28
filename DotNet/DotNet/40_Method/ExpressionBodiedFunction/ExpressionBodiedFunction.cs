using System;

class ExpressionBodiedFunction
{
    static void Main()
    {
        Work();
        Walk();
    }

    static void Work()
    {
        Console.WriteLine("일을 합니다."); // [1] 기본 형식
    }

    static void Walk() => Console.WriteLine("산책을 합니다."); // [2] 축약 형식
}
