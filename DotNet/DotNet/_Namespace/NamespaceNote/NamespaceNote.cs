//[?] 네임스페이스: 클래스 등의 사용자 정의 형식의 이름 충돌 방지 및 관련 기능끼리 묶어서 관리
using System;

namespace Foo
{
    public class Car
    {
        public void Go() => Console.WriteLine("[1] Foo 네임스페이스의 Car 클래스 호출");
    }
}

namespace Bar
{
    public class Car
    {
        public void Go() => Console.WriteLine("[2] Bar 네임스페이스의 Car 클래스 호출");
    }
}

class NamespaceNote
{
    static void Main()
    {
        Foo.Car fooCar = new Foo.Car();
        fooCar.Go(); // [1] Foo 네임스페이스의 Car 클래스 호출
        Bar.Car barCar = new Bar.Car();
        barCar.Go(); // [2] Bar 네임스페이스의 Car 클래스 호출
    }
}
