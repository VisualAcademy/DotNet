//[?] 클래스의 인스턴스 멤버 호출
using System;

// RectangleClass.cs
class RectangleClass
{
    static void Main()
    {
        // Rectangle 클래스의 인스턴스를 생성
        Rectangle rectangle = new Rectangle();
        Console.WriteLine(rectangle.GetName()); // 직사각형
    }
}
