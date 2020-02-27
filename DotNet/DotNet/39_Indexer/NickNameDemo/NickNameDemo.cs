using System;

namespace NickNameDemo
{
    class NickNameDemo
    {
        static void Main()
        {
            //[A] NickName 클래스의 인스턴스(개체) 생성
            var nick = new NickName();

            //[B] 문자열 인덱서 사용
            nick["박용준"] = "RedPlus"; // Key와 Value 형태로 저장
            nick["김태영"] = "Taeyo";

            //[C] 문자열 인덱서 값 출력
            Console.WriteLine($"{nick["박용준"]}, {nick["김태영"]}");
        }
    }
}
