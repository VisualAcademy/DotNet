using System;

class WhileExam
{
    static void Main()
    {
        int number = 3;

        while (number <= 9)
        {
            Console.WriteLine(number); // 3, 6, 9
            number = number + 3; // 3씩 증가
        }
    }
}
