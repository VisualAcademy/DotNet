using System;

class DelegateDemo
{
    // 함수 생성
    static void Hi() => Console.WriteLine("안녕하세요.");
    // 대리자 생성
    delegate void SayDelegate();
    static void Main()
    {
        // Hi 함수를 say 이름으로 대신해서 호출
        SayDelegate say = Hi;
        say();
    }
}
