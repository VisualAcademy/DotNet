// <예제> 클래스 레벨의 메서드 호출: ClassNote.cs
using System;

class ClassNote
{
    static void Run()
    {
        Console.WriteLine("ClassNote 클래스의 Run 메서드");
    }

    static void Main()
    {
        Run(); //[1] 메서드 레벨: 같은 클래스의 메서드 호출
        ClassNote.Run(); //[2] 클래스 레벨: 클래스.메서드() 형태로 호출
    }
}
