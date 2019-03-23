using System;

class PrecedenceQuiz
{
    static void Main()
    {
        int number = 1;
        int result = 0;

        result = 8 >> 2 * number++ - (3 % 2);

        Console.WriteLine(result);
    }
}
