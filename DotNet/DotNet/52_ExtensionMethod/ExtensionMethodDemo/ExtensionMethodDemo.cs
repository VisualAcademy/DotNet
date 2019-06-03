//[?] 확장 메서드: 기존 형식에 새로운 메서드를 추가하는 방법
using System;

namespace ExtensionMethodDemo
{
    // static 정적(고정) == shared(공유)
    public static class MyClass
    {
        /// <summary>
        /// 특정 문자열의 단어 개수
        /// </summary>
        /// <param name="str">문자열</param>
        /// <returns>단어 개수</returns>
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    class ExtensionMethodDemo
    {
        static void Main()
        {
            string s = "안녕하세요? 확장 메서드... ...";
            Console.WriteLine(s.Length); // [1] 문자의 개수
            Console.WriteLine(s.WordCount()); // [2] 단어의 개수
        }
    }
}
