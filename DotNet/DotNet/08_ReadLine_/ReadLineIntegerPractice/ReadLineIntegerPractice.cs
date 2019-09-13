//[?] 콘솔로부터 정수 입력받기
using System;

class ReadLineIntegerPractice
{
    static void Main()
    {
        Console.WriteLine("정수를 입력하세요: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(number);
    }
}
