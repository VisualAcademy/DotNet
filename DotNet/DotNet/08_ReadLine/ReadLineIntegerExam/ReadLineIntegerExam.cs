using System;

class ReadLineIntegerExam
{
    static void Main()
    {
        Console.WriteLine("2개의 정수를 입력하세요: ");
        int first = Convert.ToInt32(Console.ReadLine());    // "10"
        int second = Convert.ToInt32(Console.ReadLine());   // "20"
        Console.WriteLine(first);  // 10
        Console.WriteLine(second); // 20
    }
}
