// <예제> 클래스와 멤버 생성: ClassAndMember.cs
using System;

// [1][1] 클래스 생성
public class ClassName
{
    // [1][2] 멤버 생성: 메서드 멤버 생성
    public static void MemberName()
    {
        Console.WriteLine("클래스의 멤버가 호출되어 실행됩니다.");
    }
}

public class ClassAndMember
{
    public static void Main()
    {
        // [2][1] 클래스 사용
        ClassName.MemberName(); // 정적(Static) 멤버 접근
    }
}
