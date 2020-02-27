using System;

namespace DotNet
{
    //[1] 제네릭 클래스 설계
    public class Hello<T>
    {
        private T _message; //[A] 필드
        public Hello() { _message = default(T); } //[B] 기본 생성자
        public Hello(T message) { this._message = message; } //[C] 매개 변수가 있는 생성자
        public void Say(T message) => 
            Console.WriteLine("{0}", message); //[D] 제네릭 메서드
        public T GetMessage() => this._message; //[E] 일반 메서드
    }

    class GenericMethod
    {
        static void Main()
        {
            //[2] 제네릭 클래스 호출
            Hello<int> hi = new Hello<int>();
            hi.Say(1234);
            Hello<string> hs = new Hello<string>();
            hs.Say("안녕");            
        }
    }
}
