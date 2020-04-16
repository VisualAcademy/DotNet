// 추상(Abstract) 클래스: 다른 클래스에게 상속을 주기 위한 클래스의 명세서 역할을 하는 클래스
// 클래스의 대한 설계서 역할, 회사내의 표준 정의(반드시 그 이름으로 무엇이가 기능 구현)
using System;

namespace 추상클래스와추상메서드
{
    // 부모, Parent, Base, Super 클래스
    public abstract class Benz // Hyundai
    {
        // 일반 멤버
        public void Run() { Console.WriteLine("달리다."); }
        // 추상 메서드: 자식 클래스에게 강제적으로 반드시 구현해라~
        public abstract void Left(); // 좌회전 기능의 프로토타입
        public abstract void Right(string msg);
    }
    // 자식, Child, Sub, Derived(파생) 클래스
    public class Car : Benz
    {
        public override void Left()
        {
            // Empty
            Console.WriteLine("좌회전하다...");
        }
        public override void Right(string msg)
        {
            Console.WriteLine(msg + "가 우회전 합니다...");
        }
    }
    // 테스트 영역
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(); car.Run(); car.Left(); car.Right("내 자동차");
        }
    }
}
