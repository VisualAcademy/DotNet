using System;

namespace 상속
{
    public class Parent : Object
    {
        public static void Hi() => Console.WriteLine("안녕하세요.");
    }
    public class Child : Parent
    {
        public static void Hello() => Console.WriteLine("반갑습니다.");
    }
    public class 상속 : System.Object
    {
        public static void Main()
        {
            Child.Hi();
            Child.Hello();
        }
    }
}
