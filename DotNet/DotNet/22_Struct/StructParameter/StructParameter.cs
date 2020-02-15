using System;

namespace StructParameter
{
    // Member 구조체 선언
    struct Member
    {
        public string Name;
        public int Age;
    }

    class StructParameter
    {
        static void Main()
        {
            //[1] 변수 사용
            string name = "홍길동";
            int age = 21;
            Print(name, age); // 매개 변수를 따로 선언

            //[2] 구조체 사용 
            Member m;
            m.Name = "백두산";
            m.Age = 100;
            Print(m); // 구조체 매개 변수를 사용하여 전달
        }

        static void Print(string name, int age) =>
            Console.WriteLine($"이름: {name}, 나이: {age}");

        static void Print(Member member) =>
            Console.WriteLine($"이름: {member.Name}, 나이: {member.Age}");
    }
}
