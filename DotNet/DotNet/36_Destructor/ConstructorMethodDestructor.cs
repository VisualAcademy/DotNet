using System;

namespace ConstructorMethodDestructor
{
    public class Car
    {
        // [1] 필드
        private string color;
        // [2][1] 생성자: 기본 생성자
        public Car()
        {
            color = "검정";
            Console.WriteLine("{0}색 자동차를 조립합니다.", color);
        }
        // [2][2] 생성자: 매개 변수가 있는 생성자
        public Car(string color)
        {
            this.color = color; // this.필드 = 매개변수;
            Console.WriteLine("{0}색 자동차를 조립합니다.", color);
        }
        // [3] 메서드
        public void Go() => Console.WriteLine("{0}색 자동차가 달립니다.", color);
        // [4] 소멸자: GC 엔진 알아서 소멸시킴
        ~Car() => Console.WriteLine("{0}색 자동차를 폐차합니다.", this.color);
    }

    class ConstructorMethodDestructor
    {
        static void Main()
        {
            // Car 클래스의 인스턴스 생성
            Car car = new Car(); // 생성
            car.Go(); // 호출

            // 폐차: 시점을 알 수 없다. GC 엔진이 알아서 실행

            // 매개변수가 있는 생성자를 호출
            Car whiteCar = new Car("하얀");
            whiteCar.Go();

            Car blueCar = new Car("파랑");
            blueCar.Go();
        }
    }
}
