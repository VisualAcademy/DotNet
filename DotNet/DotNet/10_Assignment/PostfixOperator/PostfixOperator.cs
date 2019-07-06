// 후위(Postfix) 증감 연산자: 우선순위가 낮음
using System;

class PostfixOperator
{
    static void Main()
    {
        int x = 3;

        int y = x++;

        Console.WriteLine(y); // 3
    }
}
