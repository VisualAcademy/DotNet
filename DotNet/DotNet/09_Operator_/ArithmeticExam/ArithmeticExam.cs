//[?] 콘솔로부터 2개의 실수를 입력 받은 후 간단한 산술 연산 진행
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
