using System;

namespace 상속_메서드오버라이드
{
    public class Parent
    {
        public void Say() { Console.WriteLine("안녕하세요."); }
        public void Run() { Console.WriteLine("달리다."); }
        public virtual void Walk() { Console.WriteLine("걷다"); }
    }
    public class Child : Parent
    {
        //public void Say() { Console.WriteLine("반갑습니다."); }
        public new void Say() { Console.WriteLine("반갑습니다."); }
        public new void Run() { Console.WriteLine("달리다."); }
        public override void Walk()
        {
            base.Walk(); // 부모의 기능 더하기 자식에서 새롭게 정의
            Console.WriteLine("계속 걷다");
        }
    }
    class 상속_메서드오버라이드
    {
        static void Main()
        {
            // 메서드 오버로드(overload) : 함수 중복(다중) 정의
            Hi(); Hi("반갑습니다.");
            // 메서드 오버라이드(override) : 함수 재 정의
            Child c = new Child();
            c.Say(); // 재 사용
            c.Run(); // X -> new
            c.Walk(); // virtual -> override
        }
        private static void Hi(string p) { Console.WriteLine(p); }
        private static void Hi() { Console.WriteLine("안녕하세요."); }
    }
}
