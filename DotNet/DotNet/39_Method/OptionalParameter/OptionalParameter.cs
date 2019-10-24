//[?] 선택적 매개 변수와 명명된 매개 변수
using System;

class OptionalParameter
{
    static void Main()
    {
        Console.WriteLine(Sum(3, 5)); // [1] 3 + 5

        //[A] 선택적 매개 변수(Optional Parameter)
        Console.WriteLine(Sum()); // [2] 10 + 20
        Console.WriteLine(Sum(40)); // [3] 40 + 20
        Console.WriteLine(Sum(100, 200)); // [4] 100 + 200

        //[B] 명명된 매개 변수(Named Parameter)
        Console.WriteLine(Sum(first: 5, second: 4)); // [5] 5 + 4
        Console.WriteLine(Sum(second: 3, first: 2)); // [6] 2 + 3
        Console.WriteLine(Sum(second: 50)); // [7] 10 + 50
    }

    static int Sum(int first = 10, int second = 20)
    {
        return first + second;
    }
}
