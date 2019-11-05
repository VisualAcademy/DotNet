//[?] 추상 클래스(Abstract Class): 
//    기본(부모) 클래스 역할을 하여 파생(자식) 클래스에게 
//    특정 멤버를 반드시 구현하도록 멤버 리스트를 제공
using System;

namespace AbstractClassShape
{
    //[1] 추상 클래스
    public abstract class Shape
    {
        //[2] 추상 멤버: 추상 메서드
        public abstract double GetArea();
    }

    //[3] 추상 클래스를 상속하는 클래스
    public class Square : Shape
    {
        private int _size;

        public Square(int size)
        {
            _size = size;
        }

        // 부모 클래스인 Shape 추상 클래스의 추상 멤버인 GetArea() 메서드를 구현
        public override double GetArea()
        {
            return _size * _size;
        }
    }

    class AbstractClassShape
    {
        static void Main()
        {
            //[A] 자신의 이름으로 인스턴스 생성
            Square square = new Square(10);
            Console.WriteLine(square.GetArea()); // 100

            //[B] 부모의 이름으로 인스턴스 생성
            Shape shape = new Square(5);
            Console.WriteLine(shape.GetArea()); // 25
        }
    }
}
