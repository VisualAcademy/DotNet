using System;

class WhilePractice
{
    static void Main()
    {
        int number = 0;

        while (number <= 4)
        {
            Console.WriteLine(number); // 0, 2, 4
            number = number + 2; // 2씩 증가
        }
    }
}
