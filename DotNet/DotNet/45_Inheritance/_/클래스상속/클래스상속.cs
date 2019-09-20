using System;

namespace 클래스상속
{
    public class ParentClass : Object
    {
        public void Print1()
        {
            Console.WriteLine("부모 클래스에서 정의한 내용");
        }
    }

    public class ChildClass : ParentClass
    {
        public void Print2()
        {
            Console.WriteLine("자식 클래스에서 정의한 내용");
        }
    }

    public class 클래스상속
    {
        public static void Main(string[] args)
        {
            // 부모 클래스의 인스턴스 생성
            ParentClass p = new ParentClass();
            p.Print1();
            // 자식 클래스의 인스턴스 생성
            ChildClass c = new ChildClass();
            c.Print1(); // 부모 클래스로부터 물려받은 기능
            c.Print2(); // 자식 클래스에 직접 구현한 기능
        }
    }
}
