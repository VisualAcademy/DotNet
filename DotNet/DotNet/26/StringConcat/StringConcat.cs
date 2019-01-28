//[?] 문자열 연결: 더하기 연산자, String.Concat() 메서드
using System;

class StringConcat
{
    static void Main()
    {
        string s1 = "안녕" + "하세요.";
        string s2 = String.Concat("반갑", "습니다.");
        Console.WriteLine($"{s1} {s2}");
    }
}
