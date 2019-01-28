using System;

namespace ClassPass
{
    // 클래스 선언: 설계도
    class Car
    {
        // Empty
    }

    class ClassPass
    {
        static void Main()
        {
            //[1] 개체 선언: 클래스의 인스턴스 생성: (예)자동차 설계도로부터 하나의 자동차 생성
            Car car1 = new Car();
            //[2] 개체의 GetHashCode 메서드로 고유 키 값 출력
            Console.WriteLine(car1.GetHashCode());

            Car car2 = new Car();
            Console.WriteLine(car2.GetHashCode());
        }
    }
}
