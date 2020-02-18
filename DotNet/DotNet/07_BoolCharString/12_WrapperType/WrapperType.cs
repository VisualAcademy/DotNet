// 래퍼 형식: int, string과 같은 기본 형식을 클래스 또는 구조체로 감싼 .NET 형식
using System;

class WrapperType
{
    static void Main()
    {
        int number1 = 1234; // int 키워드: 기본 형식
        Int32 number2 = 1234; // System.Int32 구조체: .NET 형식
        Console.WriteLine($"{number1}, {number2}");

        string str1 = "안녕"; // string 키워드: 기본 형식
        String str2 = "안녕"; // System.String 클래스: .NET 형식
        Console.WriteLine($"{str1}, {str2}");
    }
}
