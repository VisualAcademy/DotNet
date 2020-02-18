// <예제> 정적 메서드와 인스턴스 메서드: MyFirstClass.cs
using System;

class MyFirstClass
{
    static void StaticMethod() => Console.WriteLine("[1] 정적 메서드");

    void InstanceMethod() => Console.WriteLine("[2] 인스턴스 메서드");

    static void Main()
    {
        //[1] 정적 메서드 호출
        MyFirstClass.StaticMethod();
        //[2] 인스턴스 메서드 호출: new 키워드로 새로운 개체 생성하는 코드 모양
        MyFirstClass my = new MyFirstClass();
        my.InstanceMethod(); 
    }
}
