// 메서드: 동작/행위 : 자동차의 동작/기능
// 생성자(Constructor) 메서드: 클래스에서 제일 먼저 실행, 자동차 조립/시동걸기
// 소멸자(Desctructor) 메서드: 클래스에서 제일 마지막에 실행, 자동차 폐차/시동끄기
using System;

namespace 생성자_메서드_소멸자
{
    public class Car
    {
        // 필드
        private string color;
        // 생성자
        public Car()
        {
            color = "검정";
            Console.WriteLine("{0}색 자동차를 조립합니다.", color);
        }
        public Car(string color)
        {
            this.color = color; // this.필드 = 매개변수;
            Console.WriteLine("{0}색 자동차를 조립합니다.", color);
        }
        // 메서드
        public void Go()
        {
            Console.WriteLine("{0}색 자동차가 달립니다.", color);
        }
        // 소멸자: GC 엔진 알아서 소멸시킴
        ~Car()
        {
            Console.WriteLine("{0}색 자동차를 폐차합니다.", this.color);
        }
    }
    class 생성자_메서드_소멸자
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
