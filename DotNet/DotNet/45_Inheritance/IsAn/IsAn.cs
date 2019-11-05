//[?] 상속(Inheritance)은 영어로 is a(is an) 관계를 표현
using System;

namespace IsAn
{
    class Vehicle { }

    class Car : Vehicle { }

    class Airplane : Vehicle { }

    class IsAn
    {
        static void Main()
        {
            // 운송 수단(탈것) is a Vehicle.
            Vehicle vehicle = new Vehicle();

            // 자동차 is a Vehicle.
            Vehicle car = new Car();

            // 비행기 is a Vehicle.
            Vehicle airplane = new Airplane();

            // 출력: 개체를 문자열로 출력하면 ToString() 메서드가 실행됨 
            Console.WriteLine($"{vehicle}, {car}, {airplane}");
        }
    }
}
