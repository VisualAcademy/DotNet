using System;

class 람다식_소개
{
    static void Main(string[] args)
    {
        //[1] 람다식 사용 전
        int a = 3;
        int b = 5;
        int r = 0;

        r = Add(a, b);
        Console.WriteLine(r);

        //[2] 람다식 사용 후: 
        // => : 람다 연산자라고 함
        Func<int, int, int> f = (x, y) => (x + y);

        r = f(3, 5);
        Console.WriteLine(r);
    }

    private static int Add(int a, int b)
    {
        return a + b;
    }
}
