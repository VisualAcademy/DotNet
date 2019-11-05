//[?] 추상(Abstact) 클래스: 다른 클래스에게 상속을 지정(강제)하는 클래스
using System;

namespace MustInheritDemo
{
    // 부장님(?) 클래스 생성
    abstract class GeneralManager
    {
        public abstract void SayHumor(); // 메서드 본문 생략
    }

    // 부장님 클래스를 상속하는 사람 클래스 생성
    class Person : GeneralManager
    {
        public override void SayHumor()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("1+1은? 노가다!");
        }
    }

    class MustInheritDemo
    {
        static void Main()
        {
            var person = new Person();
            person.SayHumor();
        }
    } 
}
