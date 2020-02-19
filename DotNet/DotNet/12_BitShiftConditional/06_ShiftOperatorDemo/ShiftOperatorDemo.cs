using System;

class ShiftOperatorDemo
{
    static void Main()
    {
        int number = 2; // 0010

        Console.WriteLine(number << 1); // 0010 -> 0100 : 4
        Console.WriteLine(number >> 1); // 0010 -> 0001 : 1
    }
}
