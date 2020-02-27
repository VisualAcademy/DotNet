// 선택적 매개 변수(Optional Parameter)
using System;

namespace 선택적매개변수
{
    class 선택적매개변수
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5)); // 5 + 1
            Console.WriteLine(Add(5, 3)); // 5 + 3
        }

        static int Add(int a, int b = 1)
        {
            return a + b;
        }
    }
}