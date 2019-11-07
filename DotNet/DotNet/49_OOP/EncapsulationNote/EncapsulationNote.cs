//[?] 캡슐화(Encapsulation): 필드(예를들어 자동차 부품...)는 꽁꽁 숨겨라! => private
using System;

namespace EncapsulationNote
{
    public class Person
    {
        //[1] 필드
        private string name;
        //[2] 메서드: public 메서드 또는 속성으로 외부에 공개
        public void SetName(string n) => name = n;
        public string GetName() => this.name;
    }
    class EncapsulationNote
    {
        static void Main()
        {
            //[A] person 개체 생성
            Person person = new Person();
            //[B] Set 메서드로 필드 설정
            person.SetName("C#");
            //[C] Get 메서드로 필드 공개 
            Console.WriteLine(person.GetName());
        }
    }
}
