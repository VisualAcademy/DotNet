// 정수를 이진수 문자열로 표현하기 
using System;

class BinaryString
{
    static void Main()
    {
        byte x = 10; // 0000 1010

        // x를 2진수로 표현하되, 8자리로 하고 앞부분은 모두 0으로 채운다
        Console.WriteLine(
            $"십진수: {x} -> 이진수: {Convert.ToString(x, 2).PadLeft(8, '0')}");
    }
}
