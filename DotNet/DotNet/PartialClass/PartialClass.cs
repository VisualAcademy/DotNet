//[?] 부분 클래스(Partial Class): 하나 이상의 동일한 클래스에 멤버를 나눠서 관리 
using System;

namespace PartialClass
{
    //[1] 클래스에 partial 키워드를 붙여 부분 클래스로 설정하고 멤버 제공
    public partial class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    //[2] 부분 클래스의 다른 클래스/파일에 정의된 멤버 사용 가능 
    public partial class Person
    {
        public void Print() => Console.WriteLine($"{Name}: {Age}");
    }

    class PartialClass
    {
        static void Main()
        {
            //[A] 부분 클래스인 Person 클래스의 인스턴스 생성
            Person person = new Person();

            //[B] 멤버가 함께 노출되는 것 확인
            person.Name = "C#";
            person.Age = 20;

            //[C] 출력
            person.Print();
        }
    }
}
