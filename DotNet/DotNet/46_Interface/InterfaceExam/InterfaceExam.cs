using System;

// 인터페이스
interface IPerson
{
    void Work();
}

// 클래스
class Person : IPerson
{
    public void Work() => Console.WriteLine("일을 합니다.");
}

// 메인
class InterfaceExam
{
    static void Main()
    {
        Person person = new Person();
        person.Work(); 
    }
}
