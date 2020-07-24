namespace OverrideDemo
{
    class Parent
    {
        protected void Say() => System.Console.WriteLine("부모_안녕하세요.");
        protected void Run() => System.Console.WriteLine("부모_달리다.");
        public virtual void Walk() => System.Console.WriteLine("부모_걷다.");
        public virtual void Work() => System.Console.WriteLine("부모_프로그래머");
    }

    class Child : Parent
    {
        //public void Say() => System.Console.WriteLine("자식_안녕하세요.");
        public new void Say() => System.Console.WriteLine("자식_안녕하세요.");
        public new void Run() => System.Console.WriteLine("자식_달리다.");
        public override void Walk() => base.Walk(); // 관대한 부모의 의견을 따르다.
        public override void Work() => System.Console.WriteLine("자식_프로게이머");
    }

    class OverrideDemo
    {
        static void Main()
        {
            Child child = new Child(); 
            child.Say(); // 자식이 예의가 없는 경우: X -> X
            child.Run(); // 자식이 예의가 있는 경우: X -> new
            child.Walk(); // 부모도 관대하고 자식도 예의가 있는 경우: virtual -> override
            child.Work(); // 부모도 관대하고 자식도 예의가 있는 경우: virtual -> override
        }
    }
}
