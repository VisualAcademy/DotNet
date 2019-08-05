using System;

class LambdaExpressionWithFunc
{
    static void Main()
    {
        //[1] 매개 변수가 int이고 반환값이 int인 람다 식
        Func<int, int> square = x => x * x;
        Console.WriteLine(square(3)); // 9 

        //[2] 무명 메서드와 람다 식 비교
        Func<int> getNumber1 = delegate () { return 1234; };
        Console.WriteLine(getNumber1());

        Func<int> getNumber2 = () => 1234;
        Console.WriteLine(getNumber2());

        Func<int, int> addOne1 = delegate (int x) { return x + 1; };
        Console.WriteLine(addOne1(10));

        Func<int, int> addOne2 = x => x + 1;
        Console.WriteLine(addOne2(10));

        Func<string, string, string> plus1 = delegate (string a, string b) { return $"{a} {b}"; };
        Console.WriteLine(plus1("Hello", "World"));

        Func<string, string, string> plus2 = (a, b) => $"{a} {b}";
        Console.WriteLine(plus2("Hello", "World"));
    }
}
