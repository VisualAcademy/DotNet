//[?] Expression Bodied Methods: C# 6.0의 새로운 기능
using System;

class ExpressionBodiedMethodDemo
{
    static void Main()
    {
        Hello(); // Hello. 
        Console.WriteLine(DoubleValue(4)); // 8
        Console.WriteLine(Sum(3, 5)); // 8
    }

    // Expression Bodied Methods: => Lambda Operator 사용
    static void Hello() => Console.WriteLine("Hello.");
    static int DoubleValue(int val) => val * 2;
    static int Sum(int a, int b) => a + b;
}
