//[?] 리플렉션: 특정 클래스 등에 대한 정보(메타데이터)를 반환시켜주는 기능
using System;
using System.Reflection;

namespace 리플렉션_멤버정보
{
    class Test
    {
        public void TestMethod() { }
    }

    class 리플렉션_멤버정보
    {
        static void Main()
        {
            // Test 클래스에 대한 멤버 정보 얻기
            Type t = typeof(Test);

            // 인스턴스 멤버 기준으로 출력
            // MemberInfo[] members = t.GetMembers();

            // 원하는 멤버를 조건에 따라 출력
            MemberInfo[] members = t.GetMembers(
                BindingFlags.Instance | BindingFlags.Static |
                BindingFlags.NonPublic | BindingFlags.Public
            ); 

            // 멤버 출력: C# 버전에 따라 다르게 출력될 수 있음
            foreach (var member in members)
            {
                Console.WriteLine("{0}", member.Name);
            }
        }
    }
}
