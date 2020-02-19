using System;

namespace 연산자_괄호연산자_변환연산자
{
    class 연산자_괄호연산자_변환연산자
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e;

            a = 2.5 * 5 / 2.0;
            b = 2.5 * (5 / 2.0);    // 괄호 연산자 : 우선 순위 변경
            c = 5 / 2;              // 정수형으로 나누면 소수점 자리를 무시한다.
            d = 5 / 2.0;            // 실수형으로 나누면 소수점 자리 포함
            e = 5 / (double)2;      // 변환(Casting;Covert) 연산자

            Console.WriteLine("2.5 * 5 / 2.0 = {0}", a);
            Console.WriteLine("2.5 * (5 / 2.0) = {0}", b);
            Console.WriteLine("5 / 2 = {0}", c); // 2.5 -> 2
            Console.WriteLine("5 / 2.0 = {0}", d); // 2.5
            Console.WriteLine("5 / (double)2 = {0}", e); // 2.5
        }
    }
}
