using System;

class StringInterpolation
{
    static void Main()
    {
        // 문자열 보간(String Interpolation) 
        string message = "String Interpolation";
        Console.WriteLine("Message: {0}", message); // WriteLine() 메서드 기본 제공
        Console.WriteLine("Message: " + message); // 더하기 연산자
        Console.WriteLine($"Message: {message}"); // 문자열 보간법
    }
}
