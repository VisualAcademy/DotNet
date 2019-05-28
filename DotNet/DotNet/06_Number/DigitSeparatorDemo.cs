using System;

class DigitSeparatorDemo
{
    static void Main()
    {
        int bin = 0b0001_0001; // 0001 0001 
        int dec = 1_000_000; // 1,000,000
        int hex = 0xA0_B0_C0; // A0 B0 C0

        Console.WriteLine(bin); // 17
        Console.WriteLine(dec); // 1000000
        Console.WriteLine(hex); // ‭10531008‬
    }
}
