using System;

class IncrementDecrementExam
{
    static void Main()
    {
        Console.Write("정수 입력: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("실수 입력: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        number1++;
        number2--;

        Console.WriteLine($"정수: {number1}, 실수: {number2}");
    }
}
