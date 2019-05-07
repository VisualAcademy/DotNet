using System;

class BitwiseAssignment
{
    static void Main()
    {
        byte num1 = 4; // 4: 0000_0100
        byte num2 = 4; // 4: 0000_0100
        byte num3 = 4; // 4: 0000_0100
        byte num4 = 4; // 4: 0000_0100
        byte num5 = 4; // 4: 0000_0100

        num1 &= 5;  // 5(0101) & 4(0100) => 4(0000_0100)
        num2 |= 1;  // 1(0001) & 4(0100) => 5(0000_0101)
        num3 ^= 2;  // 2(0010) & 4(0100) => 6(0000_0110) 
        num4 <<= 1; // 4(0100) << 1 => 8(0000_1000)
        num5 >>= 1; // 4(0100) >> 1 => 2(0000_0010)

        Console.WriteLine(num1); // 4
        Console.WriteLine(num2); // 5
        Console.WriteLine(num3); // 6
        Console.WriteLine(num4); // 8
        Console.WriteLine(num5); // 2
    }
}
