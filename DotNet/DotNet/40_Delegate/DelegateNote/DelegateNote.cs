// DelegateNote.cs
using System;

class DelegateNote
{
    //[1] 대리자 생성: 매개변수도 없고 반환 값이 없는 함수(메서드)를 담을 수 있는 포인터
    delegate void SayPointer();

    //[2] 샘플 함수 생성 
    static void Hello() => Console.WriteLine("Hello Delegate");

    static void Main()
    {
        //[A] 대리자의 인스턴스 생성 후 매개변수로 대신 실행할 함수명 전달 
        SayPointer sayPointer = new SayPointer(Hello);

        //[B] 대리자 인스턴스로 함수 대신 호출하는 2가지 방법
        sayPointer(); // 대리자 변수에 괄호를 붙여 메서드 호출 
        sayPointer.Invoke(); // 명시적으로 Invoke() 메서드 호출
    }
}
