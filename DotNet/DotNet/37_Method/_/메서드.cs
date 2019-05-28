// 메서드.cs
using System;

namespace 메서드
{
    public class MethodClass
    {
        // 값 형식 인수, 참조 형식 인수, 반환 형식 인수 사용 메서드
        public static void Print(int a, ref int b, out int c)
        {
            a = 30;
            b = 40;
            c = a + b;
            Console.WriteLine("[1] {0}, {1}, {2}", a, b, c);
        }

        // 가변형 매개변수 사용 메서드
        public static void Print(params int[] 정수배열)
        {
            foreach (int 정수변수 in 정수배열)
            {
                Console.Write("{0} ", 정수변수);
            }
            Console.WriteLine();
        }
    }

    public class 메서드
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c; // 초기화 시키지 않고 변수명만 넘김
            MethodClass.Print(a, ref b, out c);
            Console.WriteLine("[2] {0}, {1}, {2}", a, b, c);

            //[1] 값을 직접 설정하는 방법
            MethodClass.Print(10);
            //[2] 배열을 설정하는 방법
            int[] intNum = { 10, 20 };
            MethodClass.Print(intNum);
            //[3] 배열의 참조를 넘겨주는 방법
            MethodClass.Print(
                new int[] { 10, 20, 30 });
        }
    }
}
