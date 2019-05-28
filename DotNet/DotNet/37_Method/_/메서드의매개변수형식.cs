using System;

namespace 메서드의매개변수형식
{
    public class Util
    {
        public static void Print(int a)
        {
            Console.WriteLine("{0}", a);
        }
        public static void Print(int a, ref int b)
        {
            b = 30; // ref는 C언어에서의 포인터(*)
            Console.WriteLine("{0}, {1}", a, b);
        }
        public static void Print(int a, ref int b, out int c)
        {
            c = a + b; // out은 호출한 쪽(Main)으로 전달하는 역할
            Console.WriteLine("{0}, {1}, {2}", a, b, c);
        }
        //[!] 가변형 매개변수: 매개변수를 여러개(1, 2, 3, ...)
        public static void Print(params string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("{0}", s[i]);
            }
        }
    }

    class 메서드의매개변수형식
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c; // 초기화 시키지 않고 변수명만 넘기

            // 값 전달 : Call By Value : 즉, 값이 복사(Copy), Main에도 a 생성, Print에서 a 생성
            Util.Print(a);
            // 참조 전달 : Call By Reference : 즉, 데이터는 Main에서만 하나 생성
            Util.Print(a, ref b);
            // OUTPUT 매개변수 : Main은 공간만, 저장(초기화)은 다른 메서드에서
            Util.Print(a, ref b, out c);
            Util.Print("안녕하세요.");
            Util.Print("안녕하세요.", "반갑습니다.");
            Util.Print("안녕하세요.", "반갑습니다.", "또 만나요.");
        }
    }
}
