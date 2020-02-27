using System;

namespace 클래스와객체
{
    // 클래스 선언/정의: 자동차 클래스 => 자동차 설계도
    class Car
    {
        public void Hi()
        {
            Console.WriteLine("안녕하세요.");
        }
        public void Go()
        {
            Console.WriteLine("전진하다.");
        }
    }

    class 클래스와객체
    {
        static void Main()
        {
            // 클래스 사용: 클래스의 인스턴스(Instance;실체;객체;개체) 생성
            Car car = new Car();
            car.Hi(); // car 객체(Object;개체)의 Hi() 메서드 호출
            car.Go();

            // 클래스 사용: 
            //     자동차 설계도로부터 하나의 자동차(객체;개체;Object)를 
            //     생성(조립;인스턴스화;객체화)
            Car myCar = new Car();
            myCar.Hi();
            myCar.Go();
        }
    }
}
