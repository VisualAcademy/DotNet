using System;

namespace 변환연산자
{
    public class Car
    {
        private string name;
        public Car(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
        //[!] 변환연산자 구현
        public static implicit operator Car(string name)
        {
            // 생성자에게 재 전송
            return new Car(name);
        }
    }

    class 변환연산자
    {
        static void Main(string[] args)
        {
            //Car car;        
            //car = new Car("에쿠스");
            //Car car = new Car("에쿠스");
            Car car = "에쿠스";
            Console.WriteLine("{0}", car.Name);

            Car myCar = "마이카"; // new Car("마이카");
        }
    }
}
