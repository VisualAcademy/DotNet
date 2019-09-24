using System;

class ShortcutOperator
{
    static void Main()
    {
        int x = 3;
        int y = 3;

        x = x + 2; // 기본형
        y += 2; // 축약형

        Console.WriteLine($"x: {x}, y: {y}");
    }
}
