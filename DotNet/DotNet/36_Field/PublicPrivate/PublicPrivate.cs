//[?] public과 private 액세스 한정자  
using System;

public class TestClass
{
    // 필드 선언
    // 접근 한정자(Access Modifier): public, private, protected, ...
    // private(비공개): 해당 클래스내에서만 사용
    private static string name = "홍길동";

    // public(공개;제한없음): 다른 클래스에서도 사용 가능
    public static string siteName = "길벗"; // public 필드는 권장하지 않음

    // 메서드 선언
    public static string GetName()
    {
        return name;
    }
}

class PublicPrivate
{
    static void Main()
    {
        // TestClass.name; -> private 멤버는 외부에 노출되지 않음
        Console.WriteLine(TestClass.siteName); // public 멤버는 외부에 노출
        // private 필드의 값을 외부에 공개하고자할 때에는 public으로 공개
        Console.WriteLine(TestClass.GetName());
    }
}
