// DelegateDemo.cs
//[?] 대리자: 영어 단어의 delegate는 "위임하다" 또는 "대신하다"의 뜻
using System;

class DelegateDemo
{
    //[1] 함수 생성 -> 매개 변수도 없고 반환값도 없는 함수
    static void Hi() => Console.WriteLine("안녕하세요.");

    //[2] 대리자 생성 -> 매개 변수도 없고 반환값도 없는 함수를 대신 실행할 대리자
    delegate void SayDelegate();

    static void Main()
    {
        //[A] Hi 함수를 say 이름으로 대신해서 호출
        SayDelegate say = Hi;
        say();

        //[B] Hi 함수를 hi 이름으로 대신해서 호출: 또 다른 모양
        var hi = new SayDelegate(Hi);
        hi();
    }
}
