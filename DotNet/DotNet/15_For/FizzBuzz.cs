using System;

class FizzBuzz
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0) // 3의 배수이고 그리고 5의 배수일 때
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0) // 3의 배수일 때
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0) // 5의 배수일 때
            {
                Console.WriteLine("Buzz");
            }
            else // 3의 배수 또는 5의 배수 또는 3과 5의 공배수가 아닐 때
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
