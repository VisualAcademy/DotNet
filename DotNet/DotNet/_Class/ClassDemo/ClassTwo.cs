using System;

//[2] ClassTwo 클래스
public class ClassTwo
{
    // 정적(static) 멤버
    public static void Hi()
    {
        Console.WriteLine("반갑습니다.");
    }

    // 인스턴스(instance) 멤버: static 없는 인스턴스 메서드
    public void Hello()
    {
        Console.WriteLine("또 만나요.");
    }
}
