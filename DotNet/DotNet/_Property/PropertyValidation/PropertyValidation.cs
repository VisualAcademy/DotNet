//[?] 특정 속성은 null 또는 빈 값이 들어오면 안되는 경우 => 생성자를 사용하여 초기화
using System;

namespace PropertyValidation
{
    class Car
    {
        public string Name { get; private set; }
        public Car(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                // 빈 값이면 강제로 ArgumentException 예외 발생
                throw new ArgumentException(); 
            }
            this.Name = name;
        }
    }

    class PropertyValidation
    {
        static void Main()
        {
            //[1] 정상 실행
            Car car = new Car("자동차");
            Console.WriteLine(car.Name); // 자동차

            //[2] 예외 발생
            //Console.WriteLine((new Car("")).Name); // 예외 발생
        }
    }
}
