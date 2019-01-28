using System;

namespace MethodNew
{
    class Parent
    {
        public void Work()
        {
            Console.WriteLine("프로그래머");
        }
    }

    class Child : Parent
    {
        // 기본 멤버 숨기기: new -> 새롭게 정의, 다시 정의 
        public new void Work()
        {
            Console.WriteLine("프로게이머");
        }
    }

    class MethodNew
    {
        static void Main()
        {
            var child = new Child();
            child.Work(); // "프로게이머"
        }
    }
}
