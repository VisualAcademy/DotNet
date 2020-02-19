using System;
using static System.Console;

class ShiftLeft
{
    static void Main()
    {
        WriteLine("C# 시프트 연산자: <<");

        byte x = 0b0000_0011; // 3
        WriteLine($@"{nameof(x),10}: {Convert.ToString(x, 2)
            .PadLeft(8, '0')} -> {x,2}");
        WriteLine($@"x = x << 1: {Convert.ToString(x << 1, 2)
            .PadLeft(8, '0')} -> {x << 1,2} = {x} * (2)");
        WriteLine($@"x = x << 2: {Convert.ToString(x << 2, 2)
            .PadLeft(8, '0')} -> {x << 2,2} = {x} * (2 * 2)");
        WriteLine($@"x = x << 3: {Convert.ToString(x << 3, 2)
            .PadLeft(8, '0')} -> {x << 3,2} = {x} * (2 * 2 * 2)");
    }
}
