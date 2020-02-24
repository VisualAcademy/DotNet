// Function Scope: 함수(메서드) 범위, 전역 변수와 지역 변수
using System;

public class FunctionScope
{
    static string message = "전역 변수"; // 필드

    static void ShowMessage()
    {
        string message = "지역 변수";
        Console.WriteLine(message);  // 지역 변수
    }

    static void Main()
    {
        ShowMessage();
        Console.WriteLine(message); // 전역 변수
    }
}
