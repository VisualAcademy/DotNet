// 캡슐화(Encapsulation) : 필드(자동차 부품)는 꽁꽁 숨겨라! => private
using System;

namespace 캡슐화
{
    public class Person
    {
        // 필드
        private string name;
        // public한 메서드로 외부에 공개/외부에서 설정
        // Set 메서드
        public void SetName(string n)
        {
            name = n;
        }
        // Get 메서드
        public string GetName()
        {
            return this.name;
        }
    }

    class 캡슐화
    {
        static void Main(string[] args)
        {
            //[1] public한 필드를 사용해서 데이터 저장 및 출력
            //Person saram1 = new Person();
            //saram1.name = "홍길동";
            //Console.WriteLine(saram1.name); 

            //[2] public한 메서드를 통한 데이터 저장 및 출력
            Person p = new Person();
            p.SetName("백두산"); // C#에서는 속성으로 대체 가능
            Console.WriteLine(p.GetName());
        }
    }
}
