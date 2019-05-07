using System;

class ShiftExam
{
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(number << 5 >> 2);
    }
}
