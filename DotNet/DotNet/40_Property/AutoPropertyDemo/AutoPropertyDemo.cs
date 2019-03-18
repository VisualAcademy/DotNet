using System;

namespace AutoPropertyDemo
{
    class AutoPropertyDemo
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine($"{p.Id}, {p.Name}");
        }
    }

    class Person
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "홍길동";
    }
}
