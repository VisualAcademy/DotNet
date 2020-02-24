using System;

class DigitSeparatorDescription
{
    static void Main()
    {
        // Digit Separator
        int num = 1_000_000; // 1,000,000의 표현 방식
        int[] numbers = { 0b1, 0B10, 0b0100, 0B0000_1000 };

        Console.WriteLine(num);
        foreach (var n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}
