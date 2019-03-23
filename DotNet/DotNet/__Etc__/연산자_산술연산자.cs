// +, -, *, /, %(MOD; 나머지)
using System;

public class 연산자_산술연산자
{
    public static void Main()
    {
        int a = 5;
        int b = 3;

        Console.WriteLine(a + b); // 8

        // Alt + 마우스 드래그 => 박스선택
        Console.WriteLine(a - b); // 2
        Console.WriteLine(a * b); // 15
        Console.WriteLine(a / b); // 몫: 1  
        Console.WriteLine(
            "{0} % {1} = {2}", a, b, (a % b)); // 몫: 1, 나머지: 2
    }
}
