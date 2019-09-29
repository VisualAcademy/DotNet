// ^ 연산자: 비트 XOR 연산자(서로 다르면 1)
using System;
using static System.Console;

class BitXor
{
    static void Main()
    {
        byte x = 0b_1010; // 10
        byte y = 0b_1100; // 12

        // x를 이진수로 표현 -> 십진수로 표현
        WriteLine($"  {Convert.ToString(x, 2)} -> {x}");

        // y를 이진수로 표현 -> 십진수로 표현
        WriteLine($"^ {Convert.ToString(y, 2)} -> {y}");

        WriteLine($"------");

        // x XOR y를 이진수로 표현 -> 십진수로 표현 
        WriteLine($"  {Convert.ToString(x ^ y, 2).PadLeft(4, '0')} -> {x ^ y,2}");
    }
}
