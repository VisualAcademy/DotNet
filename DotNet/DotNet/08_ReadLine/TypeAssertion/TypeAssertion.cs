// 타입 어설션(추론, 추정, 추측)
using System;

class TypeAssertion
{
    static void Main()
    {
        var number = 1234; // int number;
        Console.WriteLine(number.GetType()); // System.Int32

        var message = "안녕하세요."; // string message;
        Console.WriteLine(message.GetType()); // System.String 
    }
}
