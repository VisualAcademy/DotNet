using System;

namespace 부모의멤버접근
{
    // Car.cs
    public class Car
    {
        private string name; // 이름
        public Car() { }
        public Car(string name)
        {
            this.name = name;
        }
        public void Run()
        {
            Console.WriteLine(
                "{0}가 달린다.", this.name);
        }
    }
    public class Hyundai : Car
    {
        public Hyundai() : this("현대자동차")
        {
            // Empty    
        }
        public Hyundai(string name) : base(name)
        {
            // 부모클래스 : base
        }
    }
    public class Samsung : Car
    {
        public Samsung() : base("삼성자동차") { }
    }

    // 부모의멤버접근.cs 
    class 부모의멤버접근
    {
        static void Main(string[] args)
        {
            Hyundai sonata =
                new Hyundai("소나타");
            sonata.Run(); // 소나타가 달린다.

            Hyundai santafe =
                new Hyundai();
            santafe.Run(); // 현대자동차가 달린다.

            Samsung sm =
                new Samsung();
            sm.Run();
        }
    }
}
