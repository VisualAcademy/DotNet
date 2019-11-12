using System;

namespace GenericNote
{
    class Juice { }
    class Coffee { }

    //[1] Cup of T, Cup<T>
    class Cup<T>
    {
        public T Type { get; set; }
    }

    class GenericNote
    {
        static void Main()
        {
            //[A] T 형식 매개 변수로 Juice 클래스 전송
            Cup<Juice> juice = new Cup<Juice>();
            juice.Type = new Juice();
            Console.WriteLine(juice.Type.ToString()); // GenericNote.Juice

            //[B] T 형식 매개 변수로 Coffee 클래스 전송
            var coffee = new Cup<Coffee> { Type = new Coffee() };
            Console.WriteLine(coffee.Type.ToString()); // GenericNote.Coffee
        }
    }
}
