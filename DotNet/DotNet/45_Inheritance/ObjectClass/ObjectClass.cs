using System;

namespace ObjectClass
{
    public class Parent : System.Object
    {
        public static void Hi() => Console.WriteLine("안녕하세요.");
    }

    public class Child : Parent
    {
        public static void Hello() => Console.WriteLine("반갑습니다.");
    }

    class ObjectClass : Object 
    {
        static void Main()
        {
            Child.Hi();
            Child.Hello();
        }
    }
}
