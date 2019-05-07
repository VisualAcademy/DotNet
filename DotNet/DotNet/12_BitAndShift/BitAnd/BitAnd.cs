// & 연산자: 비트 AND 연산자(둘 다 1일때만 1)
using System;

class BitAnd
{
    static void Main()
    {
        byte x = 0b1010; // 10
        byte y = 0b1100; // 12

        // x를 이진수로 표현 -> 십진수로 표현
        Console.WriteLine($"  {Convert.ToString(x, 2)} -> {x}");

        // y를 이진수로 표현 -> 십진수로 표현
        Console.WriteLine($"& {Convert.ToString(y, 2)} -> {y}"); 

        Console.WriteLine($"------");

        // x AND y를 이진수로 표현 -> 십진수로 2칸 잡고 표현 
        Console.WriteLine($"  {Convert.ToString(x & y, 2)} -> {x & y, 2}");
    }
}
