using System;

namespace 함수
{
    public class 함수
    {
        //[!] Main 메서드(함수) : 프로그램의 진입점
        public static void Main()
        {
            //[1] 매개변수도 없고 반환값도 없는 메서드 : Sub
            Hi(); Hi();

            //[2] 매개변수(파라미터,인자,인수)가 있는 메서드 : Sub
            Hello("반갑습니다"); Hello("반갑습니다");

            //[3] 반환값이 있는 메서드 : Function
            Console.WriteLine("3의 제곱 : {0}", Power(3));

            //[4] 매개변수가 가변인 경우 : 메서드 오버로드
            Multi(); Multi("안녕하세요"); Multi("반갑습니다", 3);

            //[5] 전역변수와 지역변수 출력
            Console.WriteLine("전역변수 i가 호출됨 : {0}", i); // 20
            int j = 10; // 지역변수 선언
            Console.WriteLine("지역변수 j가 호출됨 : {0}", j); // 10
        }

        //[1] Hi() 함수 선언
        public static void Hi()
        {
            Console.WriteLine("안녕하세요");
        }

        //[2] Hello(string s) 함수 선언
        public static void Hello(string s)
        {
            Console.WriteLine(s);
        }

        //[3] Power(int i) : 제곱근
        public static int Power(int i)
        {
            return (i * i);
        }

        //[4] Multi(...) : 동일한 이름의 메서드 여러 개 존재 가능
        public static void Multi() { }
        public static void Multi(string s) { }
        public static void Multi(string s, int i) { }

        //[5] 전역변수(Global Variable) 선언
        public static int i = 20; // 전역변수, 공유(공용)변수, 필드
    }
}
