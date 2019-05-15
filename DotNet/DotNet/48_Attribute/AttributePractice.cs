using System;

// [1] Attribute 클래스를 상속하여 사용자 지정 특성 만들기 
public class SampleAttribute : Attribute
{
    public SampleAttribute() => Console.WriteLine("사용자 지정 특성 사용됨");
}

[Sample]
public class CustomAttributeTest { }

class AttributePractice
{
    static void Main()
    {
        // [2] CustomAttributeTest 클래스에 적용된 특성들 가져오기 
        Attribute.GetCustomAttributes(typeof(CustomAttributeTest));
    }
}
