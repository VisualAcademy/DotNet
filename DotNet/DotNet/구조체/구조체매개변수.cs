using System;

// 구조체
public struct Member
{
    public string Name;
    public int Age;
}

// 클래스
public class 구조체매개변수
{
    public static void Main()
    {
        //[1] 변수
        string Name = "홍길동"; int Age = 21;
        Print(Name, Age);
        //[2] 구조체
        Member m; m.Name = "백두산"; m.Age = 100;
        Print(m);
    }

    private static void Print(Member m)
    {
        Console.WriteLine("이름 : {0}, 나이 : {1}", m.Name, m.Age);
    }

    private static void Print(string Name, int Age)
    {
        Console.WriteLine("이름 : {0}, 나이 : {1}", Name, Age);
    }
}
