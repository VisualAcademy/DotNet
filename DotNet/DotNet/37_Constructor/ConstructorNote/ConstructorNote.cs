//[?] 생성자: 클래스 이름과 동일한 메서드, 클래스의 필드를 초기화하는 역할
using System;

namespace ConstructorNote
{
    public class Person
    {
        //[1] 필드
        private string name;
        //[2] 매개변수가 없는 생성자
        public Person()
        {
            name = "홍길동";
        }
        //[3] 매개변수가 있는 생성자
        public Person(string n)
        {
            name = n;
        }
        //[4] 메서드: 이름의 값을 외부에 공개
        public string GetName()
        {
            return name;
        }
    }
    class ConstructorNote
    {
        static void Main()
        {
            //[1] 매개변수가 없는 기본 생성자 호출
            Person saram1 = new Person();
            Console.WriteLine(saram1.GetName()); // 홍길동
            var saram2 = new Person();
            Console.WriteLine(saram2.GetName()); // 홍길동
            //[2] 매개변수가 있는 생성자 호출
            Person person1 = new Person("백두산");
            Console.WriteLine(person1.GetName()); // 백두산
            var person2 = new Person("임꺽정");
            Console.WriteLine(person2.GetName()); // 임꺽정
        }
    }
}
