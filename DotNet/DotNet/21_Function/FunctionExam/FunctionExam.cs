// 덧셈 함수 만들기
using System;

class FunctionExam
{
    static void Main()
    {
        decimal r = Add(3.0M, 0.14m);
        Console.WriteLine($"{r:0.00}"); // 3.14
        Console.WriteLine($"{Add(r, 0.001592m)}"); // 3.141592 
    }

    static decimal Add(decimal a, decimal b)
    {
        return a + b; 
    }
}
