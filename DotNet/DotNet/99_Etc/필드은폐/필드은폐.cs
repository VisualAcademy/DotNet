using System;

namespace 필드은폐
{
    class Parent
    {
        //[1] 필드 숨김: 필드는 무조건 private으로 설정
        private string _Word;

        //[2] protected는 자식 클래스에서만 호출 가능한 멤버
        protected string Word
        {
            get { return _Word; }
            set { _Word = value; }
        }
    }

    class Child : Parent
    {
        public void SetWord(string word)
        {
            base.Word = word;
        }
        public string GetWord()
        {
            return Word;
        }
    }

    class 필드은폐
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.SetWord("안녕하세요.");
            Console.WriteLine(child.GetWord());
        }
    }
}
