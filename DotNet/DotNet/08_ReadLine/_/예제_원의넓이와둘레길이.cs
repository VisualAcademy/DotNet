using System;

namespace CalculateAreaAndCircumferenceOfCircleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 상수 선언: PI = 3.141592654...
            const float PI = 3.141592654f;

            // 변수 선언
            float r;

            // 사용자로부터 반지름 입력
            Console.Write("반지름: ");
            r = float.Parse(Console.ReadLine());

            // 처리 및 출력
            Console.WriteLine("원의 넓이: {0}", (r * r * PI));
            Console.WriteLine("원의 둘레 길이: {0}", (2 * r * PI));
        }
    }
}
