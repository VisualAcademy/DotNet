// <예제> 문자열을 특정 열거형으로 변환하기: EnumParse.cs
using System;

class EnumParse
{
    static void Main()
    {
        string color = "Red"; // 열거형에 없는 상수 문자열을 지정하면 예외

        // [1] 문자열을 가지고 지정 문자열에 해당하는 열거 상수를 가져오기
        Console.ForegroundColor = // ConsoleColor.Red;
            (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);

        Console.WriteLine("Red");
        Console.ResetColor();
    }
}
