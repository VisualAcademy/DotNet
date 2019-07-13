//[?] &&(AND) 연산자: 둘 다 참일 때에만 참
using System;

class AndOperator
{
    static void Main()
    {
        //[A] 둘 다 참일때에만 참
        Console.WriteLine(true && true); // True
        //[B] 하나라도 거짓이면 거짓
        Console.WriteLine(true && false); // False
    }
}
