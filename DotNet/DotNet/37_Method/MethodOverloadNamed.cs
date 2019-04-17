//[?] 명명된 매개변수를 사용하여 메서드 오버로드 구현하기
using System;

public class Messenger
{
    public void PrintMessage(string message, string prefix = "", string suffix = "")
    {
        Console.WriteLine($"{prefix}{message}{suffix}");
    }
}

class MethodOverloadNamed
{
    static void Main()
    {
        Messenger messenger = new Messenger();
        messenger.PrintMessage("My"); // [A]
        messenger.PrintMessage(prefix: "Oh ", message: "My"); // [B]
        messenger.PrintMessage(prefix: "Oh ", message: "My ", suffix: "God"); // [C] 
    }
}
