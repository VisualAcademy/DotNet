using System;

namespace 클래스와인스턴스
{
    // 클래스는 새로운 Type, 종류, 분류 정의
    // Dog 클래스
    public class Dog
    {
        // 필드(멤버변수, 전역변수)
        private string name; // 이름 필드
                             // 메서드
        public void Cry()
        {
            Console.WriteLine(name + "가 멍멍멍");
        }
        // 생성자
        public Dog()
        {
            name = "해피";
        }
        // 매개변수가 있는 생성자
        public Dog(string name)
        {
            this.name = name;
        }
    }

    class 클래스와인스턴스
    {
        static void Main(string[] args)
        {
            // 인스턴스/개체/객체는 실체, 구체적인 것 정의
            Dog happy = new Dog();
            happy.Cry();
            Dog worry = new Dog("워리");
            worry.Cry();
        }
    }
}
