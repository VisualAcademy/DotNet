using System;

namespace 읽기전용필드
{
    class Car
    {
        //[1] 선언과 동시에 초기화
        public readonly int MinPrice = 0;
        //[2] 선언 후 생성자를 통한 초기화
        public readonly string Maker;
        public Car()
        {
            Maker = "Benz";
        }
        public Car(string maker)
        {
            Maker = maker;
        }
    }

    class 읽기전용필드
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            // car.MinPrice = 100; // Error
            // car.Maker = "BMW"; // Error
            Console.WriteLine($"{car.Maker}, {car.MinPrice}");

            Car bmw = new Car("BMW");
            Console.WriteLine($"{bmw.Maker}, {bmw.MinPrice}");
        }
    }
}
