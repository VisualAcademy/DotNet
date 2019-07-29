using System;

class IfElseIfElse
{
    static void Main()
    {
        int number1 = 10;
        int number2 = 20;

        if (number1 > number2) // 조건 처리 1
        {
            Console.WriteLine("number1이 더 큽니다.");
        }
        else if (number1 < number2) // 조건 처리 2
        {
            Console.WriteLine("number2가 더 큽니다.");
        }
        else
        {
            Console.WriteLine("둘 다 같습니다.");
        }
    }
}
