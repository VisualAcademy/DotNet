using System;
using static System.Console;

class FormatExceptionDemo
{
    static void Main()
    {
        string inputNumber = "3.14";
        int number = 0;

        try
        {
            number = Convert.ToInt32(inputNumber);
            WriteLine($"입력한 값: {number}");
        }
        catch (FormatException fe)
        {
            WriteLine($"에러 발생: {fe.Message}");
            WriteLine($"{inputNumber}는 정수여야 합니다.");
        }
    }
}
