//[?] 필드(Field): 클래스 안에서 생성된 변수(멤버변수)
using System;

namespace FieldNote
{
    class Person
    {
        //[1] 변수 형식의 필드
        private string name = "박용준";
        //[2] 상수 형식의 필드
        private const int m_age = 21;
        //[3] 읽기전용 형식의 필드
        private readonly string _NickName = "RedPlus";
        //[4] 배열 형식의 필드
        private string[] _websites = { "닷넷코리아", "비주얼아카데미" };
        //[5] 모든 형식의 필드
        private object all = DateTime.Now.ToShortTimeString();
        public void ShowProfile()
        {
            string r = 
                $"{name}, {m_age}, {_NickName}, {String.Join(", ", _websites)}, " +
                $"{Convert.ToDateTime(all).ToShortTimeString()}";
            Console.WriteLine(r);
        }
    }
    class FieldNote
    {
        static void Main()
        {
            Person person = new Person();
            person.ShowProfile();
        }
    }
}
