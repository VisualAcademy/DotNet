using System;

namespace OperatorOverload
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

    class OperatorOverload
    {
        static void Main()
        {
            Car car = "생성자에 직접 문자열을 전달함";
            Console.WriteLine(car.Name);
        }
    }
}
