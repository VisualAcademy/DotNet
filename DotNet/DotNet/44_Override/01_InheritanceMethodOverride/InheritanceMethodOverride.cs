using System;

namespace InheritanceMethodOverride
{
    public class Parent
    {
        public void Say() => Console.WriteLine("부모_안녕하세요.");
        public void Run() => Console.WriteLine("부모_달리다.");
        public virtual void Walk() => Console.WriteLine("부모_걷다.");
    }
    public class Child : Parent
    {
        //public void Say() => Console.WriteLine("자식_안녕하세요.");
        public new void Say() => Console.WriteLine("자식_안녕하세요.");
        public new void Run() => Console.WriteLine("자식_달리다.");
        public override void Walk() => Console.WriteLine("자식_걷다.");
    }
    class InheritanceMethodOverride
    {
        static void Main()
        {
            // 메서드 오버라이드(override): 함수 재정의
            Child c = new Child();
            c.Say(); //[1] 재사용
            c.Run(); //[2] x -> new
            c.Walk(); //[3] virtual -> override
        }
    }
}
