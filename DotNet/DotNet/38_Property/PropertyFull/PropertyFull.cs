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
            Person person = new Person();
            person.Name = "Gilbut"; // set
            Console.WriteLine(person.Name); // get
        }
    }
}
