//[?] 바이너리 리터럴(Binary Literal)
using System;

class BinaryLiteral
{
    static void Main()
    {
        // 0b 또는 0B로 시작하는 정수 리터럴은 이진수 리터럴
        byte b1 = 0b0010; // 이진수 0010 -> 십진수 2 
        byte b2 = 0B1100; // 이진수 1100 -> 십진수 12

        // 컴퓨터에서는 자동으로 십진수 단위로 처리함
        Console.WriteLine($"10진수: {b1}"); // 10진수: 2
        Console.WriteLine($"10진수: {b2}"); // 10진수: 12
    }
}
