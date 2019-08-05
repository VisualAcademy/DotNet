// 할당(대입) 연산자: +=, -=, *=, /=, %=
using System;

class 연산자_할당연산자
{
    static void Main()
    {
        int a = 3;
        int b = 5;
        
        b += a; // 누적: b변수에 a변수의 값을 누적

        Console.WriteLine("{0}", b); // 8

        // 현재 b는 8

        b -= a; // 가감: b에서 a를 뺀 후 다시 b에 할당
        Console.WriteLine("{0}", b); // 5
    }
}
