//[?] 정적(Static, Shared) 멤버와 인스턴스(Instance) 멤버 
using System;

namespace StaticAndInstance
{
    //[1] 클래스 생성
    class SharedAndInstance
    {
        //[1][1] static(shared) 멤버
        public static void StaticMember() => Console.WriteLine("[1] Static Member");

        //[1][2] instance 멤버
        public void InstanceMember() => Console.WriteLine("[2] Instance Member");
    }

    class StaticAndInstance
    {
        static void Main()
        {
            //[2] 클래스 사용
            //[2][1] 정적 멤버 사용
            SharedAndInstance.StaticMember(); // 정적 멤버 => 클래스.멤버 형태

            //[2][2] 인스턴스 멤버 사용
            SharedAndInstance obj = new SharedAndInstance();
            obj.InstanceMember(); // 인스턴스 멤버 => 개체.멤버 형태
        }
    }
}
