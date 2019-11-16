using System;

namespace GenericsDemo
{
    //[1] 형식 매개 변수 2개 사용 
    class Pair<T, V>
    {
        public T First { get; set; }
        public V Second { get; set; }

        public Pair(T first, V second)
        {
            First = first;
            Second = second;
        }
    }

    class GenericsDemo
    {
        static void Main()
        {
            //[A] string, bool 2개 형식 받기
            var my = new Pair<string, bool>("나는 멋져!", true);
            Console.WriteLine($"{my.First}: {my.Second}");

            //[B] int, double 2개 형식 받기
            var tuple = new Pair<int, double>(1234, 3.14);
            Console.WriteLine($"{tuple.First}, {tuple.Second}");
        }
    }
}
