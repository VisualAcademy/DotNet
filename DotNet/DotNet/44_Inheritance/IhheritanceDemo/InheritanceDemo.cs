//[?] 상속(Inheritance): 부모 클래스의 기능을 자식 클래스에서 물려받아 사용
using System;

namespace InheritanceDemo
{
    //[1] 부모 클래스 선언
    class Parent
    {
        public void Foo() => Console.WriteLine("부모 클래스의 멤버 호출");
    }

    //[2] 자식 클래스 선언
    class Child : Parent
    {
        public void Bar() => Console.WriteLine("자식 클래스의 멤버 호출");
    }

    class InheritanceDemo
    {
        static void Main()
        {
            // 자식 클래스의 인스턴스 생성
            var child = new Child();
            child.Foo(); // 부모 클래스의 멤버 호출
            child.Bar(); // 자식 클래스의 멤버 호출
        }
    }
}
