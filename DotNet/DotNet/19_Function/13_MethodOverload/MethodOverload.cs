// MethodOverload.cs
//[?] 메서드 오버로드: 동일한 이름의 메서드를 매개 변수를 달리하여 여러 개 생성(다중 정의)
using System;

class MethodOverload
{
    // 매개 변수가 없는 Hi() 함수
    static void Hi()
    {
        Console.WriteLine("안녕하세요.");
    }

    // 매개 변수가 있는 Hi() 함수
    static void Hi(string msg)
    {
        Console.WriteLine(msg);
    }

    static void Main()
    {
        Hi();
        Hi("반갑습니다.");
    }
}
