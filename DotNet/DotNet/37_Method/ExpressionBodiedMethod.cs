using System;

class ExpressionBodiedMethod
{
    static void Main()
    {
        Log("함수 축약");
        Console.WriteLine(IsSame("A", "B")); // False
    }

    static void Log(string message) => Console.WriteLine(message);

    static bool IsSame(string a, string b) => a == b;
}
