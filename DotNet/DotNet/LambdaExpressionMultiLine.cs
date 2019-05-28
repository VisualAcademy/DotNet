using System;

class LambdaExpressionMultiLine
{
    delegate void Hi();
    static void Main()
    {
        Hi hi = () =>
        {
            Console.WriteLine("안녕하세요.");
            Console.WriteLine("반갑습니다.");
        };
        hi();
    }
}
