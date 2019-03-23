// 필드.cs
using System;

namespace 필드
{
    public class Person
    {
        //[!] 필드(멤버변수, 전역변수(Global Variable))
        #region 필드 영역(Private Member Variables)
        //[1] 변수 형식의 필드
        public static string name = "박용준";
        //[2] 상수 형식의 필드
        public const int m_age = 21;
        //[3] 읽기전용 형식의 필드
        public static readonly object _NickName = "RedPlus";
        //[4] 배열 형식의 필드
        public static string[] _websites = { "닷넷코리아", "비주얼아카데미" };        
        #endregion

        //[!] 필드 내용 출력 메서드
        public static void ShowProfile()
        {
            // 로컬변수(Local Variable)
            string strWrite = String.Format(
                "이름: {0}\n나이: {1}\n별명: {2}\n", name, m_age, _NickName);
            strWrite += "홈페이지: ";
            foreach (string s in _websites)
            {
                strWrite += s + '\t';
            }
            strWrite += '\n';
            Console.WriteLine(strWrite);
        }
    }

    public class 필드
    {
        //[!] 메서드: Main 메서드
        public static void Main(string[] args)
        {
            // 지역 변수(LocalVariable): 특정 메서드내에서 선언된 변수
            string name = "박용준";
            Console.WriteLine(name);

            //[!] 필드를 public으로 선언했지만, 앞으로는 private을 붙인다. 
            Person.name = "홍길동";
            // Person.m_age = 22; // 이 코드는 실행 안됨
            // Person._NickName = "WhitePlus"; // 이 코드는 실행 안됨
            Person._websites[0] = "dotnetkorea";
            Person.ShowProfile(); // *
        }
    }
}


//using System;
//public class Person
//{
//    //[2] 전역 변수(Global Variable) :
//    //[!] 전역 변수 -> 멤버 변수 -> 필드(Field) : private
//    public static string name = "홍길동";
//    public int m_age = 21;
//    private static string[] _Url = { "닷넷코리아", "레드플러스" };
//    public const string SITE_NAME = "닷넷코리아";//상수형 필드
//    //읽기전용 필드 : 생성자에 의해서 딱 한번 초기화 가능
//    public static readonly object _NickName = "레드플러스";
//}
//public class 필드
//{
//    //[!] 메인 메서드 : 프로그램의 진입점
//    public static void Main(string[] args)
//    {
//        //[1] 지역 변수(Local Variable)
//        //string name = "홍길동";
//        Print();
//    }
//    //[!] 함수 -> 메서드
//    public static void Print()
//    {
//        // Person 클래스의 인스턴스 개체(Object) 생성
//        Person person = new Person();
//        Person.name = "백두산";
//        Console.WriteLine("{0}, {1}", Person.name, person.m_age);
//        //Person.SITE_NAME = "닷다섯코리아";
//        Console.WriteLine(Person.SITE_NAME);
//        //Person._NickName = "화이트플러스";
//        Console.WriteLine(Person._NickName);
//    }
//}
