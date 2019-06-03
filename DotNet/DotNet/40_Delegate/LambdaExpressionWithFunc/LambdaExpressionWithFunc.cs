using System;

class LambdaExpressionWithFunc
{
    static void Main()
    {
        // 매개 변수가 int이고 반환값이 int인 람다 식
        Func<int, int> square = x => x * x;
        Console.WriteLine(square(3)); // 9 
    }
}
