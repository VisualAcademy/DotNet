using System;

class FuncLambda
{
    static void Main()
    {
        //[1] 익명 메서드 담기
        Func<int, int> anonymous = delegate (int x) { return x * x; };
        Console.WriteLine(anonymous(2)); // 2 * 2

        //[2] 람다 식 담기
        Func<int, double> lambda = x => x / (double)2;
        Console.WriteLine(lambda(3));
    }
}
