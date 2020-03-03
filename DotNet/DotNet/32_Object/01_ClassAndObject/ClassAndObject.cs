using System;

//[1] ClassCode 이름의 클래스(Class) 만들기
public class ClassCode
{
    // Empty
}

class ClassAndObject
{
    static void Main()
    {
        //[2] 특정 클래스로부터 objectCode1, objectCode2 이름의 개체(Object) 만들기
        ClassCode objectCode1 = new ClassCode();
        Console.WriteLine(objectCode1.GetHashCode());
        var objectCode2 = new ClassCode();
        Console.WriteLine(objectCode2.GetHashCode());
    }
}
