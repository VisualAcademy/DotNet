// 함수(메서드) 오버로드(Overload; 오버로딩) : 다중 정의/여러번 정의/중복
using System;

namespace 함수오버로드
{
    class 함수오버로드
    {
        static void Main()
        {
            Multi();
            Multi("반갑습니다.");
            Multi("안녕", 3);
        }

        public static void Multi()
        {
            Console.WriteLine("안녕하세요.");
        }

        public static void Multi(string message)
        {
            Console.WriteLine(message);
        }

        public static void Multi(string msg, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0}", msg);
            }
        }
    }
}
