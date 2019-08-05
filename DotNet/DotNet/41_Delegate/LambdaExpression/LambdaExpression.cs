// 람다 식(Lambda Expression): C# 3.0에 도입됨
using System;

class LambdaExpression
{
    //[1] 대리자 선언
    delegate void Lambda();
    static void Main()
    {
        //[2] 대리자 개체에 람다식 정의: goes to 연산자
        Lambda hi = () => Console.WriteLine("안녕하세요.");
        //[3] 대리자 개체 호출
        hi();
    }
}
