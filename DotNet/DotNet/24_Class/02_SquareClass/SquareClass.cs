//[?] 클래스의 정적 멤버 호출
using System;

//[1] Square.cs
public class Square
{
    public static string GetName()
    {
        return "정사각형";
    }
}

//[2] SquareClass.cs 
class SquareClass
{
    static void Main()
    {
        // Square 클래스의 정적(static) 멤버인 GetName() 메서드 호출
        string square = Square.GetName();
        Console.WriteLine(square); // 정사각형
    }
}
