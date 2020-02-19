// ~ 연산자: 비트 NOT 연산자(1 <-> 0, 비트 반전)
using System;
using static System.Console;

class BitNot
{
    static void Main()
    {
        byte x = 0b_0000_1010; // 10

        // x를 8자리 이진수로 표현 -> 십진수로 3자리 잡고 표현
        WriteLine($"~ {Convert.ToString(x, 2).PadLeft(8, '0')} -> {x, 3}");
        WriteLine($"----------");

        // NOT x를 8자리 이진수로 표현 -> 십진수로 3자리 잡고 표현 
        WriteLine($"  {Convert.ToString((byte)~x, 2).PadLeft(8, '0')} -> {~x, 3}");
    }
}
