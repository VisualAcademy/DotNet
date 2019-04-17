using System;

namespace GreeterDemo
{
    // 클래스 선언
    class Greeter
    {
        // 필드
        private string _greeting;
        // 생성자 선언
        public Greeter(string greeting)
        {
            this._greeting = greeting; 
        }
        // 메서드 선언
        public string GetGreeter()
        {
            return this._greeting;
        }
    }

    class GreeterDemo
    {
        static void Main()
        {
            Greeter greeter = new Greeter("안녕하세요.");
            Console.WriteLine(greeter.GetGreeter()); // 안녕하세요. 
        }
    }
}
