// << : 왼쪽 시프트 : 비트당 2배
// >> : 오른쪽 시프트 : 비트당 1/2배
using System;

public class 연산자_시프트연산자
{
    public static void Main()
    {
        int num = 0;
        int result = 0;

        num = 2; // 4배
        result = num << 2; // 왼쪽으로 비트를 2칸 이동
        Console.WriteLine("{0}", result); // ? 8

        num = 40; // 1/4
        result = num >> 2; // 오른쪽으로 2칸 이동
        Console.WriteLine("{0}", result); // ? 10
    }
}
