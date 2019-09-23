using System;

namespace ClassAndInstance
{
    //[?] 클래스는 Type, 종류, 분류 정의
    //[1] Dog 클래스
    public class Dog
    {
        //[2] name 필드
        private string name;

        //[3] name 매개변수를 받아서 name 필드에 저장하는 생성자
        public Dog(string name)
        {
            this.name = name; // 넘겨온 name을 name 필드에 임시 저장
        }

        //[4] name 필드의 값을 출력하는 반환값이 있는 메서드
        public string Cry()
        {
            return name + "이(가) 멍멍멍";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //[?] 인스턴스/개체/객체는 실체, 구체적인 것 정의
            //[5] Dog 클래스 사용:  happy, worry => 인스턴스, 개체, ...
            Dog happy = new Dog("해피");
            Console.WriteLine(happy.Cry());
            Dog worry = new Dog("워리");
            Console.WriteLine(worry.Cry());
        }        
    }
}
