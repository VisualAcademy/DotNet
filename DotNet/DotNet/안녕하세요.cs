using System;

namespace 안녕하세요
{
    class 안녕하세요
    {
        static void Main(string[] args)
        {
            // 네임스페이스.클래스.메서드();
            System.Console.WriteLine("안녕하세요.");

            // 이스케이프시퀀스
            System.Console.Write("반갑습니다.\n");

            // 네임스페이스 선언부에 미리 선언
            Console.WriteLine("또 만나요.");

            // 자리표시자(자리채움자) : PlaceHolder
            Console.WriteLine("{0} {1}", "Hi", "Hello");
            Console.WriteLine(
                "{0} {1}",
                "Hi", "Hello");
        }
    }
}