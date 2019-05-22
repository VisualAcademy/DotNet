using System;
using System.Reflection;
namespace ReflectionGetMethod
{
    public class MemberClass
    {
        public string Name { get; set; } = "길벗출판사";
        public string GetName()
        {
            return Name + ", " + DateTime.Now.ToShortTimeString();
        }
    }

    class ReflectionGetMethod
    {
        static void Main()
        {
            //[1] 리플렉션 기능으로 특정 클래스의 멤버를 동적으로 호출(Invoke)
            MemberClass m = new MemberClass();
            Type t = m.GetType();

            //[a] 속성 읽어오기 및 속성 호출
            PropertyInfo pi = t.GetProperty("Name"); // Name 속성
            Console.WriteLine("속성 호출: {0}", pi.GetValue(m));

            //[b] 메서드 읽어오기 및 메서드 호출
            MethodInfo mi = t.GetMethod("GetName"); // GetName 메서드
            Console.WriteLine("메서드 호출: {0}", mi.Invoke(m, null));

            //[2] 참고: C# 4.0 이상에서는 dynamic 개체로 쉽게 멤버를 동적으로 호출
            dynamic d = new MemberClass(); // dynamic 키워드로 동적 개체 생성 
            Console.WriteLine("속성 호출: {0}", d.Name); // 속성 호출
            Console.WriteLine("메서드 호출: {0}", d.GetName()); // 메서드 호출       
        }
    }
}
