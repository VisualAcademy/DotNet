// 람다식: 매개변수도 있고 반환값도 있는 경우
using System;

class LambdaExpressionArgs
{
    delegate int Lambda(int i);
    static void Main()
    {
        Lambda square = x => x * x;
        Console.WriteLine(square(3)); // 9
        Console.WriteLine(square(4)); // 16
    }
}
