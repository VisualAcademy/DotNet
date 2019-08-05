// 추상클래스.cs
// 추상(Abstract) 클래스 : 다른 클래스에 상속을 주기위한 용도로
// 설계하는 클래스. 회사내 표준 정의(반드시 그 이름으로 기능 구현)
using System;

namespace 추상클래스
{

    // Parent/Base/Super 클래스
    public abstract class BMW
    {
        public void Run() { Console.WriteLine("달리다"); }
        public abstract void Back(); // 기능 구현없이 뼈대 설계
        public abstract void Left(); // 설계만...
    }

    // Child/Sub 클래스
    public class Car : BMW
    {
        public override void Back()
        {
            // 뼈대는 만들어 놓고 작업
            Console.WriteLine("후진합니다.");
        }
        public override void Left()
        {
            // Empty
        }
    }

    public class 추상클래스
    {
        public static void Main(string[] args)
        {
            Car i8 = new Car();
            i8.Run();
            i8.Back();
        }
    }
}
