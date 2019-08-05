using System;
using System.Reflection;
namespace 리플렉션_멤버호출
{
    public class Member
    {
        public Member()
        {
            Name = "길벗출판사";
        }
        public string Name { get; set; }
        public string GetName()
        {
            return Name + ", " + DateTime.Now.ToShortTimeString();
        }
    }

    class 리플렉션_멤버호출
    {
        static void Main()
        {
            //[1] 리플렉션 기능으로 특정 클래스의 멤버를 동적으로 호출(Invoke)
            Member m = new Member();
            Type t = m.GetType();

            //[a] 속성 읽어오기 및 속성 호출
            PropertyInfo pi = t.GetProperty("Name"); 
            Console.WriteLine("속성 호출: {0}", pi.GetValue(m));

            //[b] 메서드 읽어오기 및 메서드 호출
            MethodInfo mi = t.GetMethod("GetName"); 
            Console.WriteLine("메서드 호출: {0}", mi.Invoke(m, null)); 

            //[2] C# 4.0 이상에서는 dynamic 개체로 쉽게 멤버를 동적으로 호출
            dynamic d = new Member();
            Console.WriteLine("속성 호출: {0}", d.Name); // 속성 호출
            Console.WriteLine("메서드 호출: {0}", d.GetName()); // 메서드 호출       
        }
    }
}
