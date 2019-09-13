// ConsoleColor 열거형으로 콘솔의 전경색 및 배경색 바꾸기
using System;

class ConsoleColorDemo
{
    static void Main()
    {
        // 전경색
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Blue");
        Console.ResetColor();

        // 배경색
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Red");
        Console.ResetColor();
    }
}
