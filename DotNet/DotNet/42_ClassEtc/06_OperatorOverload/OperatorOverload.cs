//[!] 연산자 오버로드 맛보기 데모
using System;

namespace OperatorOverload
{
    public class Car
    {
        public string Name { get; private set; }

        public Car(string name) => Name = name;

        //[!] 변환연산자 구현
        public static implicit operator Car(string name) => new Car(name); // 생성자에게 재 전송
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
