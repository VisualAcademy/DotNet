using System;

namespace VirtualOverride
{
    class Parent
    {
        // virtual: 재 정의해서 사용하도록 허용
        public virtual void Work() => Console.WriteLine("프로그래머");
    }

    class Child : Parent
    {
        // override: 재 정의해서 사용하겠다 지정
        public override void Work() => Console.WriteLine("프로게이머");
    }

    class VirtualOverride
    {
        static void Main()
        {
            (new Parent()).Work();  // 프로그래머
            (new Child()).Work();   // 프로게이머
        }
    }
}
