// 전위(Prefix) 증감 연산자: 우선순위가 높음
using System;

class PrefixOperator
{
    static void Main()
    {
        int i = 3;

        int j = ++i;

        Console.WriteLine(j); // 4
    }
}
