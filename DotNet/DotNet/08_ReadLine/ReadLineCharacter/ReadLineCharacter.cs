using System;

class ReadLineCharacter
{
    static void Main()
    {
        Console.Write("문자를 입력하세요: ");
        string input = Console.ReadLine(); // "가"를 입력하면 
        char c = Convert.ToChar(input); // "가"를 '가'로 변환
        Console.WriteLine(c); // '가'
    }
}
