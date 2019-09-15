using System;

public interface ICar
{
    void Go();
}

public class Car : ICar
{
    public void Go()
    {
        Console.WriteLine("상속한 인터페이스에 정의된 모든 멤버를 반드시 구현해야 합니다.");
    }
}

class Interface
{
    static void Main()
    {
        Car car = new Car();
        car.Go();
    }
}
