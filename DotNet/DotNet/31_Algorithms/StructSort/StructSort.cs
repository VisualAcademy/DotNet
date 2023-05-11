using System;
using System.Linq;

namespace StructSort
{
    //사람을 나타내는 클래스
    public class Person
    {
        public int Id { get; set; } //사람의 id
        public string Name { get; set; } //사람의 이름
        public int Age { get; set; } //사람의 나이
    }

    public class Program
    {
        public static void Main()
        {
            //사람들을 나타내는 배열
            Person[] people =
            {
                new Person {Id = 1, Name = "홍길동", Age = 20},
                new Person {Id = 2, Name = "백두산", Age = 25},
                new Person {Id = 3, Name = "임꺽정", Age = 30},
                new Person {Id = 4, Name = "한라산", Age = 28},
            };

            Console.WriteLine("정렬되지 않은 사람들:");
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Id}: {person.Name}, {person.Age}");
            }

            //나이를 기준으로 사람들을 정렬
            var sortedPeople = people.OrderBy(person => person.Age).ToArray();

            Console.WriteLine("나이별로 정렬된 사람들:");
            foreach (var person in sortedPeople)
            {
                Console.WriteLine($"{person.Id}: {person.Name}, {person.Age}");
            }
        }
    }
}
