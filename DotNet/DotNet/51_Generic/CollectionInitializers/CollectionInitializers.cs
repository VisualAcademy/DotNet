//[?] 컬렉션 이니셜라이저를 사용하여 개체 여러 개를 초기화
using System;
using System.Collections.Generic;

namespace CollectionInitializers
{
    class Person
    {
        public string Name { get; set; }
    }

    class CollectionInitializers
    {
        static void Main()
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "홍길동" },
                new Person { Name = "백두산" },
                new Person { Name = "임꺽정" }
            };

            foreach (var person in people)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
