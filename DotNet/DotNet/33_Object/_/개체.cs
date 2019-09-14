using System;

namespace 개체
{
    //[1] 클래스 생성
    public class MyClass
    {
        public void MyMember()
        {
            Console.WriteLine("클래스의 인스턴스인 개체가 실행됩니다.");
        }
    }

    public class 개체
    {
        public static void Main()
        {
            //[2][1] 클래스 사용: 클래스의 인스턴스를 생성해서 개체를 만든다.
            MyClass my = new MyClass();
            //[2][2] 개체(인스턴스)명.멤버명으로 클래스의 멤버를 호출
            my.MyMember();
        }
    }
}
