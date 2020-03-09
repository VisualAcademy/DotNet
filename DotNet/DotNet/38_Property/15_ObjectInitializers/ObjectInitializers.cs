//[?] 개체 이니셜라이저를 사용하여 개체의 속성을 초기화
using System;

namespace ObjectInitializers
{
    public class Person
    {
        // 속성
        public string Name { get; set; }
        public int Age { get; set; }

        // 생성자
        public Person()
        {

        }
        public Person(string name, int age)
        {
            Name = name; Age = age;
        }
    }

    class ObjectInitializers
    {
        static void Main()
        {
            //[1] 속성 사용
            Person pp = new Person();
            pp.Name = "백두산";
            pp.Age = 100;

            //[2] 생성자 사용
            Person pc = new Person("홍길동", 21);

            //[3] 개체 이니셜라이저 사용
            Person pi = new Person { Name = "임꺽정", Age = 30 };
            Console.WriteLine($"{pi.Name}, {pi.Age}");
        }
    }
}
