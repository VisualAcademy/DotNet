// Object Initializer: 개체 이니셜라이저
using System;

namespace 개체이니셜라이저
{
    class Person
    {
        // propfull 
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        // prop: 자동으로 구현된 속성
        public int Age { get; set; }

        // 자동 속성: 속성을 자동으로 초기화(C# 6.0)
        public string Type { get; set; } = "사람";
    }

    class 개체이니셜라이저
    {
        static void Main(string[] args)
        {
            //[1] Person 클래스의 인스턴스 생성
            Person saram1 = new Person();
            saram1.Name = "홍길동";
            saram1.Age = 21;
            Console.WriteLine($"이름: {saram1.Name}, 나이: {saram1.Age}, 타입: {saram1.Type}");

            //[2] 개체 이니셜라이저를 사용하여 개체를 초기화
            Person saram2 = new Person() { Name = "백두산", Age = 99 };
            Console.WriteLine($"이름: {saram2.Name}, 나이: {saram2.Age}, 타입: {saram2.Type}");
        }
    }
}
