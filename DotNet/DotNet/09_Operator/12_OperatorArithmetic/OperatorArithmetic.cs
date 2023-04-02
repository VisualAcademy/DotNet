// 산술 연산자(Arithmetic Operator)
// +, -, *, /, %
using System;

class OperatorArithmetic
{
    static void Main()
    {
        int a = 5;
        int b = 3;

        Console.WriteLine(a + b); // 덧셈: 8
        Console.WriteLine(a - b); // 뺄셈: 2
        Console.WriteLine(a * b); // 곱셈: 15
        Console.WriteLine(a / b); // 몫: 1  
        Console.WriteLine(
            "{0} % {1} = {2}", a, b, (a % b)); // 나머지: 2
    }
}
