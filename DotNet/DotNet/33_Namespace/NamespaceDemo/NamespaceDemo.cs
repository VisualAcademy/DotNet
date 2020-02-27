using System;

namespace 네임스페이스이름
{
    // 클래스 등의 정의가 들어옴
}

namespace MyCar
{
    public class Car
    {
        // Car 클래스의 내용 구현
    }
}

namespace AllCar
{
    namespace MyCar { }
    namespace YourCar { }
}

namespace AllCar.MyCar { }
namespace AllCar.YourCar { }

namespace AllCar.MyCar
{
    public class Car
    {

    }
}

namespace UsingKeyword
{
    using System; // System 네임스페이스를 현재 CS 파일 또는 네임스페이스에서 사용하겠다고 지정
    using MyNamespace; // MyNamespace 네임스페이스를 현재 CS 파일에서 사용하겠다고 지정
    using AllCar.MyCar; // 계층형 네임스페이스를 지정

}

namespace MyNamespace
{

}

namespace NamespaceDemo
{
    class NamespaceDemo
    {
        static void Main()
        {
            Console.WriteLine("네임스페이스 데모");
            AllCar.MyCar.Car car = new AllCar.MyCar.Car();
        }
    }
}
