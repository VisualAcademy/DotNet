using System;

/// <summary>
/// 식 본문 메서드(Expression-Bodied Method) 
/// </summary>
class ExpressionBodiedMethod
{
    static void Main()
    {
        //[!] 아래에 함수를 먼저 만들고 호출해야 함
        Log("함수 축약");
        Console.WriteLine(IsSame("A", "B")); // False
    }

    static void Log(string message) => Console.WriteLine(message);

    static bool IsSame(string a, string b) => a == b;
}
