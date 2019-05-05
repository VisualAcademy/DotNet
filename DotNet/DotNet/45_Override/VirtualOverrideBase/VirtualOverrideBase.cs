using System;

namespace VirtualOverrideBase
{
    class Parent
    {
        public virtual void Work() => Console.WriteLine("프로그래머");
    }

    class Child : Parent
    {
        // sealed 키워드를 사용하여 멤버를 봉인(재정의 금지) 및 base 키워드로 부모 멤버 접근
        public override sealed void Work() => base.Work();
    }

    class GrandChild : Child
    {
        // public override void Work() => Console.WriteLine("프로게이머");
        public void Play() => Console.WriteLine("프로게이머");
    }

    class VirtualOverrideBase
    {
        static void Main()
        {
            (new Parent()).Work();      // 프로그래머
            (new Child()).Work();       // 프로그래머
            (new GrandChild()).Work();  // 프로그래머
            (new GrandChild()).Play();  // 프로게이머
        }
    }
}
