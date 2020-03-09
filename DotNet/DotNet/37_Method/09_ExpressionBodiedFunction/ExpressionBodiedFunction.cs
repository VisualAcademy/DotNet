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
        Console.WriteLine("Work"); // [1] 기본 형식
    }

    static void Walk() => Console.WriteLine("Walk"); // [2] 축약 형식
}
