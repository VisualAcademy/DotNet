// [클래스]와 [개체] 그리고 [정적 멤버]와 [인스턴스 멤버]
using System;

namespace 클래스와개체
{
    //[1] 클래스 생성
    public class 클래스
    {
        //[1][1] static(shared) 멤버
        public static void 정적멤버() { Console.WriteLine("정적"); }
        //[1][2] instance 멤버
        public void 인스턴스멤버() { Console.WriteLine("인스턴스"); }
    }

    class 클래스와개체
    {
        static void Main()
        {
            //[2] 클래스 사용
            //[2][1] 정적 멤버 사용
            클래스.정적멤버(); // "정적"
            //[2][2] 인스턴스 멤버 사용
            클래스 개체 = new 클래스();
            개체.인스턴스멤버(); // "인스턴스"
        }
    }
}
