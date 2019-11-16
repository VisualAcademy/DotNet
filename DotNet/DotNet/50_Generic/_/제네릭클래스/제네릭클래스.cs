using System;

namespace 제네릭클래스
{
    // 제네릭 클래스 설계
    public class Hello<T>
    {
        private T msg;
        public Hello() { msg = default(T); }
        public Hello(T msg) { this.msg = msg; }
        public void Say() { Console.WriteLine("{0}", this.msg); }
        public void Say(T msg) { Console.WriteLine("{0}", msg); }
        public void SayType()
        {
            T temp; temp = default(T); // int : 0, string : null, bool : false 
            Console.WriteLine("{0}", temp);
        }
        //public void SayInt(int msg) { Console.WriteLine("{0}", msg); }
        //public void SayStr(string msg) { Console.WriteLine("{0}", msg); }
        //public void SayObj(object msg) { Console.WriteLine("{0}", msg); }
    }

    class 제네릭클래스
    {
        static void Main(string[] args)
        {
            // 기본클래스 메서드 호출
            //Hello h = new Hello();
            //h.SayInt(1234); h.SayStr("안녕"); h.SayObj(DateTime.Now); 
            // 제네릭 클래스 호출
            Hello<int> hi = new Hello<int>(); hi.Say(1234);
            Hello<string> hs = new Hello<string>(); hs.Say("안녕");
            Hello<string> say = new Hello<string>("반갑습니다."); say.Say(); say.SayType();
        }
    }
}
