using System;

namespace 상속_생성자상속
{
    public class Parent
    {
        private string _Word; // 필드
        public string Word // 속성
        {
            get { return _Word; }
            set { _Word = value; }
        }
        public Parent(string _Word) // 생성자
        {
            this._Word = _Word;
        }
    }
    public class Child : Parent
    {
        public void Say() { Console.WriteLine(base.Word); }
        public Child() : this("안녕")
        {
            //base.Word = "안녕";  
        }
        public Child(string s) : base(s)
        {
            //base.Word = s; 
        }
    }
    public class 상속_생성자상속
    {
        public static void Main(string[] args)
        {
            Child c = new Child();
            c.Say(); // "안녕"
            Child c2 = new Child("또봐");
            c2.Say(); // "또봐"
        }
    }
}
