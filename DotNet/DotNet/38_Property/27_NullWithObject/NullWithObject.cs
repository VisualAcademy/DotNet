using System.Collections.Generic;
using static System.Console;

namespace NullWithObject
{
    class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }

    class Address
    {
        public string Street { get; set; } = "알 수 없음";
    }

    class NullWithObject
    {
        static void Main()
        {
            var people = new Person[] { new Person { Name = "RedPlus" }, null };

            ProcessPeople(people);

            void ProcessPeople(IEnumerable<Person> peopleArray)
            {
                foreach (var person in peopleArray)
                {
                    // [1] ?.로 널 확인 후 널이면 ?? 이후의 문자열로 초기화 
                    WriteLine($"{person?.Name ?? "아무개"}은(는) " +
                        $"{person?.Address?.Street ?? "아무곳"}에 삽니다.");
                }
            }

            var otherPeople = null as Person[];

            // [2] ?[0] 형태로 인덱서에 대해서 널 값 확인 가능
            WriteLine($"첫 번째 사람: {otherPeople?[0]?.Name ?? "없음"}");
        }
    }
}
