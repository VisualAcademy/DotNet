// | 연산자: 비트 OR 연산자(하나라도 1이면 1)
using System;
using static System.Console; // System.Console 줄여서 사용

class BitOr
{
    static void Main()
    {
        byte x = 0b1010; // 10
        byte y = 0b1100; // 12

        // x를 이진수로 표현 -> 십진수로 표현
        WriteLine($"  {Convert.ToString(x, 2)} -> {x}");

        // y를 이진수로 표현 -> 십진수로 표현
        WriteLine($"| {Convert.ToString(y, 2)} -> {y}");

        WriteLine($"------");

        // x OR y를 이진수로 표현 -> 십진수로 표현 
        WriteLine($"  {Convert.ToString(x | y, 2)} -> {x | y,2}");
    }
}
