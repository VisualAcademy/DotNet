//[?] 논리 부정 연산자: !
using System;

class LogicalNegation
{
    static void Main()
    {
        var bln = false;

        Console.WriteLine(!bln); // true 
        Console.WriteLine(!!bln); // false
        Console.WriteLine(!(!(!bln))); // true
    }
}
