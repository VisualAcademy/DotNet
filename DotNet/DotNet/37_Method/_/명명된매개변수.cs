using System;

namespace 명명된매개변수
{
    class 명명된매개변수
    {
        static void Main(string[] args)
        {
            Print(10);
            Print(6, d: "C#");
        }

        static void Print(int a, double b = 1.0, string c = "Hello", string d = "World")
        {
            Console.WriteLine($"{a}, {b}, {c}, {d}");
        }
    }
}
