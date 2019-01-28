using System;

class NullCoalescingNote
{
    static void Main()
    {
        string value = null;
        string message = "";

        //[1] if 구문으로 null 값 비교
        value = null;
        if (value == null)
        {
            message = "[1] null이면 새로운 값으로 초기화합니다.";
        }
        Console.WriteLine(message);

        //[2] ?? 연산자로 null 값 비교
        value = null;
        message = value ?? "[2] null이면 새로운 값으로 초기화합니다.";
        Console.WriteLine(message);
    }
}
