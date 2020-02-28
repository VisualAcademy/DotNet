using System;

// 클래스
class ConstructorDemo
{
    // 생성자
    public ConstructorDemo()
    {
        Console.WriteLine("생성자가 호출되었습니다.");
    }

    // 진입점
    static void Main()
    {
        ConstructorDemo c = new ConstructorDemo();
    }
}
