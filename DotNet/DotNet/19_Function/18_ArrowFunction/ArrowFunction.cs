// 화살표 함수(Arrow Function): 화살표 메서드
using System;

class ArrowFunction
{
    static void Main()
    {
        Hi(); // 안녕하세요.
        Multiply(3, 5); // 15
    }

    static void Hi() => Console.WriteLine("안녕하세요.");
    static void Multiply(int a, int b) => Console.WriteLine(a * b);
}
