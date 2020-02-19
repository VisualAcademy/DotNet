using System;

class BitExam
{
    static void Main()
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(num1 & num2);
        Console.WriteLine(num1 | num2);
        Console.WriteLine(num1 ^ num2);
        Console.WriteLine(~num1);
    }
}
