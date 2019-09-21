using System;

namespace 생성자_필드초기화
{
    public class Person
    {
        //[!] 필드
        public static string Name; // 정적인(static) 필드
        public int Age; // 비정적(instance) 필드

        //[1] 정적 개체를 생성하는 생성자
        static Person()
        {
            Name = "박용준";
        }
        //[2] 인스턴스 개체를 생성하는 매개변수 없는 생성자
        public Person()
        {
            Age = 21;
        }
        //[3] 인스턴스 개체를 생성하는 매개변수 있는 생성자
        public Person(int Age)
        {
            this.Age = Age; // this.멤버 = 생성자매개변수
        }
    }

    public class 생성자_필드초기화
    {
        static void Main()
        {
            //[1] 정적 객체를 생성
            Console.WriteLine(Person.Name);
            //[2] 인스턴스 객체를 생성
            Person person = new Person();
            Console.WriteLine(person.Age);
            //[3] 매개변수가 있는 생성자 호출
            Person saram = new Person(100);
            Console.WriteLine(saram.Age);
        }
    }
}
