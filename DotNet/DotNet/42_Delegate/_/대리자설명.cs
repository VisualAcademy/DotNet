using System;

namespace 대리자설명
{
    public class Hello
    {
        public static void Hi()
        {
            Console.WriteLine("안녕");
        }
        public void Bye()
        {
            Console.WriteLine("잘가");
        }
    }

    public class Sum
    {
        public static void Exec(
            int a, int b
        )
        {
            Console.WriteLine(a + b);
        }
    }

    //[A] 대리자 선언
    public delegate void EventHandler();
    public delegate void SumDelegate(int a, int b);
    public class 대리자설명
    {
        public static void Main(string[] args)
        {
            //[1] 다중 메서드 호출 : 따로 따로 호출
            Hello.Hi();
            Hello hello = new Hello();
            hello.Bye();
            //[2] 대리자를 통한 메서드 호출
            // 대리자형식의 변수에 2개의 메서드 등록
            EventHandler eh;
            eh = new EventHandler(Hello.Hi);
            eh += new EventHandler(hello.Bye);
            eh -= new EventHandler(Hello.Hi);//등록제거
            eh(); // 대리자를 통한 2개의 메서드 호출

            //[3] 매개변수가 있는 메서드 등록/호출
            SumDelegate sum = new SumDelegate(Sum.Exec);
            sum(10, 20); // 30
            sum(30, 30);
        }
    }
}
