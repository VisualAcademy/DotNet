//[?] 불변 형식: 개체의 상태는 생성 후 변경되지 않아야 프로그래밍 부작용을 줄임
using System;

namespace ImmutableTypeDemo
{
    public class Circle
    {
        public int Radius { get; private set; } = 0;
        public Circle(int radius) => Radius = radius;
        public Circle MakeNew(int radius) => new Circle(radius);
    }

    class ImmutableTypeDemo
    {
        static void Main()
        {
            //[1] 생성자를 통해서 반지름이 10인 Circle 개체 생성
            Circle circle = new Circle(10);
            Console.WriteLine($"Radius: {circle.Radius} - {circle.GetHashCode()}");

            //[2] 메서드를 통해서 반지름이 20인 Circle 개체 새롭게 생성
            circle = circle.MakeNew(20);
            Console.WriteLine($"Radius: {circle.Radius} - {circle.GetHashCode()}");
        }
    }
}
