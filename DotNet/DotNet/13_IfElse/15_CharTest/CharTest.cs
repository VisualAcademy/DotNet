using System;

class CharTest
{
    static void Main()
    {
        // 콘솔로부터 문자 하나 입력 받기
        Console.WriteLine("영문 대문자 또는 소문자 하나를 입력하세요.");
        char c = Convert.ToChar(Console.ReadLine());

        if (c >= 'A' && c <= 'Z')
        {
            Console.WriteLine($"{c}는 대문자입니다.");
        }
        else
        {
            Console.WriteLine($"{c}는 소문자입니다.");
        }
    }
}
