using System;

class SumOfTwoIntegers
{
    static void Main()
    {
        int a, b;
        Console.WriteLine("두 정수를 입력하세요: ");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("합: " + (a + b));
    }
}
