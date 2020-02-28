//[?] 문자열 관련 메서드 사용하기
using System;

class StringFunction
{
    static void Main()
    {
        string message = "hello, World!";

        Console.WriteLine(message.ToUpper()); // 대문자
        Console.WriteLine(message.ToLower()); // 소문자

        // 바꾸기
        Console.WriteLine(
            message.Replace("hello", "안녕하세요.").Replace("World", "세계."));
    }
}
