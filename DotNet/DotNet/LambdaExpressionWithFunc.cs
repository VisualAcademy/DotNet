using System;

class LambdaExpressionWithFunc
{
    static void Main()
    {
        Func<int, int> square = x => x * x;
        Console.WriteLine(square(3)); // 9 
    }
}
