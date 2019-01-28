// GenericNote.cs 
// 제네릭(Generics): 넘어온 타입(T)에 따라서 타입(T)이 결정됨(매개변수화된 타입)
using System;

namespace 제네릭
{
    class Juice { }
    class Coffee { }

    // Cup of T, Cup<T>
    class Cup<T>
    {
        public T Type { get; set; }
    }

    class 제네릭
    {
        static void Main(string[] args)
        {
            Cup<Juice> juice = new Cup<Juice>();
            juice.Type = new Juice();
            Console.WriteLine(juice.Type); // 제네릭.Juice

            var coffee = new Cup<Coffee> { Type = new Coffee() };
            Console.WriteLine(coffee.Type); // 제네릭.Coffee
        }
    }
}
