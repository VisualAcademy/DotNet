using System;

namespace PropertyNote
{
    class PropertyNote
    {
        static void Main(string[] args)
        {
            //[1] Car 클래스(정적) 사용
            Car.Color = "Black"; // 필드 사용
            Car.Type = "세단"; // 속성 사용
            Console.WriteLine($"차종: {Car.Type}, 색상 : {Car.Color}");

            //[2] Person 클래스(인스턴스) 사용
            Person person = new Person("박용준");
            person.BirthYear = (DateTime.Now.Year - 21); // 21살로 고정
            Console.WriteLine($"이름: {person.Name}, 나이: {person.Age}");
        }
    }
}
