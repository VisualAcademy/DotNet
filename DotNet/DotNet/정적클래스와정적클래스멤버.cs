using System;

namespace 정적클래스와정적클래스멤버
{
    using MemoEngine.Libraries;

    class 정적클래스와정적클래스멤버
    {
        static void Main(string[] args)
        {
            string s = "안녕하세요.";
            Console.WriteLine(StringLibrary.CutString(s, 2)); // 안녕

            Console.WriteLine(MemoEngine.Libraries.StringLibrary.CutString(s, 5)); // 안녕...
            Console.WriteLine(s.CutString(5)); // 안녕...


            // 추가: 유니코드 문자열 자르기, 단 콘솔 환경에서는 제대로 출력 안됨
            string u = "😎😎😎😎😎😎";
            Console.WriteLine(MemoEngine.Libraries.StringLibrary.CutStringUnicode(u, 4));
            Console.WriteLine(u.CutStringUnicode(4));
        }
    }

    public static class StringLibrary
    {
        public static string CutString(string strCut, int intChar)
        {
            return strCut.Substring(0, intChar);
        }
    }
}

namespace MemoEngine.Libraries
{
    public static class StringLibrary
    {
        /// <summary>
        /// 주어진 문자열을 주어진 길이만큼만 잘라서 반환. 나머지 부분은 '...'을 붙임.
        /// </summary>
        /// <param name="strCut">원본 문자열</param>
        /// <param name="intChar">잘라낼 길이</param>
        /// <returns>안녕하세요. => 안녕...</returns>
        public static string CutString(this string strCut, int intChar)
        {
            if (strCut.Length > (intChar - 3))
            {
                return strCut.Substring(0, intChar - 3) + "...";
            }
            return strCut;
        }

        /// <summary>
        /// 유니코드 이모티콘을 포함한 문자열 자르기
        /// </summary>
        /// <param name="str">한글, 영문, 유니코드 문자열</param>
        /// <param name="length">자를 문자열의 길이</param>
        /// <returns>잘라진 문자열</returns>
        public static string CutStringUnicode(this string str, int length)
        {
            string result = String.Empty;

            var si = new System.Globalization.StringInfo(str);
            var l = si.LengthInTextElements;
            result = si.SubstringByTextElements(0, length);

            return result;
        }

    }    
}

