using System;

namespace DotNet
{
    public enum CarType { 전기, 내연기관 }

    public abstract class CarBase
    {
        public abstract void Left(); // 추상 클래스의 추상 메서드, 본문 X, 시그니처 O => 표준(강제) => 인터페이스 
        public void Back() => Console.WriteLine("후진하다.");
        protected string LeftMessasge { get; private set; } = "좌회전하다."; // 자식에게만 멤버 노출
    }

    public class Car : CarBase
    {
        public CarType Style { get; private set; } // 공통
        public Car(CarType carType)
        {
            this.Style = carType;
        }
        public override void Left() => Console.WriteLine(base.LeftMessasge); // 실제 코드 구현, 재정의 
        public void Go() => Console.WriteLine("달리다.");
    }

    public class Benz : Car // Sub : Base
    {
        public Benz() : this(CarType.내연기관) { }
        public Benz(CarType carType) : base(carType) { }
    }

    public class Tesla : Car // Child : Parent, Child extends Parent
    {
        public Tesla() : this(CarType.전기) { }
        public Tesla(CarType carType) : base(carType) { }
    }

    // 봉인(최종) 클래스
    public sealed class Future : Car
    {
        public Future() : this(CarType.전기) { }
        public Future(CarType carType) : base(carType) { }
        public new void Go() 
        {
            base.Go(); Console.WriteLine("날다.");
        }
    }

    //public class OtherFuture : Future { }

    class InheritanceNote : Object
    {
        static void Main()
        {
            //Benz benz = new Benz(); benz.Go(); Console.WriteLine($"{benz.Style}"); benz.Back(); benz.Left();
            //Tesla tesla = new Tesla(); tesla.Go(); Console.WriteLine($"{tesla.Style}"); tesla.Back(); tesla.Left();
            Future future = new Future(); future.Go();
        }
    }
}
