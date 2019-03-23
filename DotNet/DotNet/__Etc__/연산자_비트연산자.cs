// 비트연산자
// & : AND : 논리곱
// | : OR : 논리합
// ~ : NOT : 부정
// ^ : XOR : 베타적논리합
using System;

class 연산자_비트연산자
{
    static void Main()
    {
        int a = 3;
        int b = 2;
        int r = 0;

        r = a & b;
        Console.WriteLine(r); // 2
        r = a | b;
        Console.WriteLine(r); // 3 
        r = ~a;
        Console.WriteLine(r); // -4
        r = a ^ b;
        Console.WriteLine(r); // 1
    }
}
