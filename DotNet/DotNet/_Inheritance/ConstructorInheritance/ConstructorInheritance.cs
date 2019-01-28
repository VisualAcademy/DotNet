using System;

namespace ConstructorInheritance
{
    public class Parent
    {
        public string Word { get; set; }
        public Parent(string word) // 생성자로 속성을 초기화
        {
            this.Word = word;
        }
    }

    public class Child : Parent
    {
        //[1] this() 형태로, 나 자신의 매개변수가 있는 생성자에게 기본 문자열 전달
        public Child() : this("[1] 매개변수가 없는 생성자 실행") { }

        //[2] base() 형태로, 매개변수 값을 부모 클래스의 매개변수가 있는 생성자에게 전달 
        public Child(string message) : base(message) { }
        public void Say() => Console.WriteLine(base.Word); // 부모의 World 속성 출력
    }

    class ConstructorInheritance
    {
        static void Main()
        {
            (new Child()).Say();
            (new Child("[2] 매개변수가 있는 생성자 실행")).Say();
        }
    }
}
