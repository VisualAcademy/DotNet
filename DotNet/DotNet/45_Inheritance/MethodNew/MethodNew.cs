using System;

namespace MethodNew
{
    //[1] 부모 클래스 생성
    class Parent
    {
        public void Work() => Console.WriteLine("프로그래머");
    }

    //[2] 자식 클래스 생성
    class Child : Parent
    {
        // 기본 멤버 숨기기: new -> 새롭게 정의, 다시 정의, 재정의 
        public new void Work() => Console.WriteLine("프로게이머");
    }

    class MethodNew
    {
        static void Main()
        {
            //[!] 자식 클래스의 인스턴스 생성
            var child = new Child();
            child.Work(); // "프로게이머"
        }
    }
}
