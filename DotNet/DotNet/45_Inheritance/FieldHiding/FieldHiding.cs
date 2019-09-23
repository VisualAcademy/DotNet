using System;

namespace FieldHiding
{
    class Parent
    {
        //[1] 필드 숨김: 필드는 무조건 private으로 설정
        private string _word;

        //[2] protected는 자식 클래스에서만 호출 가능한 멤버
        protected string Word
        {
            get { return _word; }
            set { _word = value; }
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
            return Word; // 부모 클래스의 Word 속성 접근
        }
    }

    class FieldHiding
    {
        static void Main()
        {
            Child child = new Child();
            child.SetWord("필드 숨기기 및 자식 클래스에게만 멤버 상속하기");
            Console.WriteLine(child.GetWord());
        }
    }
}
