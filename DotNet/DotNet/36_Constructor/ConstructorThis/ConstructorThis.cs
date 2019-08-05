using System;

namespace ConstructorThis
{
    class Say
    {
        private string message = "[1] 안녕하세요.";
        public Say() => Console.WriteLine(this.message);
        //[1] this() 생성자로 나 자신의 매개변수가 없는 생성자 먼저 호출 
        public Say(string message) : this()
        {
            //[2] 매개변수가 있는 생성자 자체도 호출 
            this.message = message;
            Console.WriteLine(this.message);
        }
    }

    class ConstructorThis
    {
        //[A] 매개변수가 있는 생성자 호출할 때 매개변수가 없는 생성자도 함께 호출
        static void Main() => new Say("[2] 잘가요.");
    }
}
