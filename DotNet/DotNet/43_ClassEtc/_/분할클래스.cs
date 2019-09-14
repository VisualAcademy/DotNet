// partial 클래스 : 한 프로젝트 또는 CS 파일에 
// 동일한 이름의 클래스를 여러개 두고자 할 때
using System;

// FirstDeveloper.cs
public partial class Hello
{
    public static void Hi() { Console.WriteLine("안녕하세요."); }
}

// SecondDeveloper.cs
public partial class Hello
{
    public static void Bye() { Console.WriteLine("잘가세요."); }
}

// Program.cs
public class 분할클래스
{
    public static void Main()
    {
        Hello.Hi();
        Hello.Bye();
    }
}
