using System;

class IntegerDemo
{
    static void Main()
    {
        int min = -2147483648; // 정수형이 가질 수 있는 가장 작은 값
        int max = +2147483647; // 정수형이 가질 수 있는 가장 큰 값

        Console.WriteLine("int 변수의 최솟값: {0}", min);
        Console.WriteLine("int 변수의 최댓값: {0}", max);
    }
}
