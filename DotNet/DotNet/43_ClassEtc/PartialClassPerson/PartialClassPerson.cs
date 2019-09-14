using System;

namespace PartialClassPerson
{
    partial class Person
    {
        public string Name { get; set; }
    }

    partial class Person
    {
        public int Age { get; set; }
    }

    class PartialClass
    {
        static void Main()
        {
            Person person = new Person();
            person.Name = "C#";
            person.Age = 20;
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
