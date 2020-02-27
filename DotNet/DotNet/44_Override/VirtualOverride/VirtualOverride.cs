//[?] virtual ~ override: 화목한 가정의 표본 
using System;

namespace VirtualOverride
{
    //[1] 부모 클래스 생성
    class Parent
    {
        // virtual: 재정의해서 사용하도록 허용
        public virtual void Work() => Console.WriteLine("프로그래머");
    }

    //[2] 자식 클래스 생성
    class Child : Parent
    {
        // override: 재정의해서 사용하겠다 지정
        public override void Work() => Console.WriteLine("프로게이머");
    }

    class VirtualOverride
    {
        static void Main()
        {
            //[A] 부모 클래스의 인스턴스 생성
            (new Parent()).Work(); // 프로그래머

            //[B] 자식 클래스의 인스턴스 생성
            (new Child()).Work(); // 프로게이머
        }
    }
}
