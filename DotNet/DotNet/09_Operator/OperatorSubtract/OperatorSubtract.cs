//[?] 빼기(-) 연산자
using System;

class OperatorSubtract
{
    static void Main()
    {
        decimal i = 3.14M;
        decimal j = 3.14M;
        decimal k = i - j; // k = 3.14 + 3.14
        Console.WriteLine(k); // 0.00
    }
}
