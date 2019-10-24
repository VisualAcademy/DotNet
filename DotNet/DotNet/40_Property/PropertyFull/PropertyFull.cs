//[?] 전체 속성 사용하기 
using System;

namespace PropertyFull
{
    class Person
    {
        // 필드
        private string name;

        // 속성
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class PropertyFull
    {
        static void Main()
        {
            var person = new Person();
            person.Name = "Gilbut"; // set
            Console.WriteLine(person.Name); // get
        }
    }
}
