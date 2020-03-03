using System;

namespace ObjectNote
{
    //[1] 클래스 생성
    public class Counter
    {
        //[2] 메서드(인스턴스 멤버) 생성
        public void GetTodayVisitCount()
        {
            Console.WriteLine("오늘 1234명이 접속했습니다.");
        }
    }
    class ObjectNote
    {
        static void Main()
        {
            //[A] 클래스의 인스턴스 생성
            Counter counter = new Counter();
            //[B] 개체(인스턴스)이름.멤버이름으로 클래스의 멤버 호출
            counter.GetTodayVisitCount();
        }
    }
}
