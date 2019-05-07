using System;

class ArithmeticExam
{
    static void Main()
    {
        double number1;
        double number2;
        double number3;

        number1 = Convert.ToDouble(Console.ReadLine()); // 5.27
        number2 = Convert.ToDouble(Console.ReadLine()); // 12.27

        number3 = number1 + number2 - 12.29; // 5.27 + 12.27 - 12.29 = 5.25

        Console.WriteLine($"{number3}");
    }
}
