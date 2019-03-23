using System;

// [1] 하나의 멤버를 갖는 인터페이스 정의
public interface IRepository
{
    void Get();
}

// [2] 인터페이스를 상속하는 클래스 구현 
public class Repository : IRepository
{
    public void Get()
    {
        Console.WriteLine("Get() 메서드를 구현해야 합니다.");
    }
}

class InterfacePractice
{
    static void Main()
    {
        // [A] 인터페이스 형식 개체에 인스턴스 담기 
        IRepository repository = new Repository();
        repository.Get();
    }
}
