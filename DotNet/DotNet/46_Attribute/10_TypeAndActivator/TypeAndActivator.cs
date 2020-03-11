using System;

namespace TypeAndActivator
{
    //[1] 샘플 클래스 및 메서드 생성
    public class MyClass
    {
        public void Test() => 
            Console.WriteLine("MyClass의 Test() 메서드가 실행됩니다.");
    }

    class TypeAndActivator
    {
        static void Main()
        {
            //[2] Type.GetType() 메서드에 지정한 클래스 형식을 가져옴
            Type type = Type.GetType("TypeAndActivator.MyClass");

            //[3] Activatory.CreateInstance() 메서드로 지정된 형식의 인스턴스 생성
            dynamic objType = Activator.CreateInstance(type);

            //[4] dynamic 타입의 Test() 메서드를 직접 지정해서 호출 
            objType.Test();
        }
    }
}
