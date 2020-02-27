using System;

// 부모 클래스
public class BaseClass
{
    public void Do() => Console.WriteLine("Base 클래스에 정의된 메서드");
}

// 자식 클래스
public class SubClass : BaseClass { } // 자식 클래스는 빈 클래스로 구현 

class BaseSub
{
    static void Main()
    {
        var sub = new SubClass();
        sub.Do(); // Base 클래스에 정의된 public 또는 protected 멤버 사용 가능
    }
}
