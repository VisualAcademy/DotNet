//[?] 논리 부정 연산자: !
using System;

class LogicalNegation
{
    static void Main()
    {
        bool bln = false;

        Console.WriteLine(!bln); // true 
        Console.WriteLine(!!bln); // false
        Console.WriteLine(!(!(!bln))); // true
    }
}
