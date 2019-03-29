// LINQ(람다식, Func대리자, Action대리자, ...)
using System;

namespace Func대리자
{
    class Program
    {
        static void Main(string[] args)
        {
            //[1] Add 함수 호출
            string r1 = Add(3, 5); // 8
            Console.WriteLine(r1);

            //[2] Func 대리자 : 반환값이 있는 메서드를 대신 호출
            Func<int, int, string> AddDelegate = Add; // Add 메서드를 대신해서 AddDelegate로 사용
            string r2 = AddDelegate(3, 5);
            Console.WriteLine(r2);

            //[3] 람다식(Lambda) : 메서드 -> 무명메서드 -> 람다식으로 줄여서 표현
            Func<int, int, string> AddLambda = (a, b) => ((a + b).ToString()); // => goes to
            string r3 = AddLambda(3, 5);
            Console.WriteLine(r3);
        }

        /// <summary>
        /// 두 수의 합을 문자열로 반환
        /// </summary>
        static string Add(int a, int b)
        {
            return (a + b).ToString();
        }
    }
}
