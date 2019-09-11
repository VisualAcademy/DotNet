using System;

class ReadLineInteger
{
    static void Main()
    {
        Console.Write("정수를 입력하세요: ");
        string input = Console.ReadLine(); // "10"을 입력한다면
        int number = Convert.ToInt32(input); // "10"을 정수 10으로 변환
        Console.WriteLine($"{number}-{number.GetType()}"); // 10-System.Int32
    }
}
