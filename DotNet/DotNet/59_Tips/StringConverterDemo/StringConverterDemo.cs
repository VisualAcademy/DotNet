//[!] 초간단 문자열 인코딩 및 디코딩
using System;

namespace StringConverterDemo
{
    /// <summary>
    /// 문자열 변환기
    /// </summary>
    public class StringConverter
    {
        /// <summary>
        /// 초간단 문자열 인코딩
        /// </summary>
        public static string ConvertToSimpleEncoding(string original)
        {
            byte[] byt = System.Text.Encoding.UTF8.GetBytes(original);
            return System.Convert.ToBase64String(byt); // 암호화
        }
        /// <summary>
        /// 초간단 문자열 디코딩
        /// </summary>
        public static string ConvertToSimpleDecoding(string modified)
        {
            byte[] byt = System.Convert.FromBase64String(modified);
            return System.Text.Encoding.UTF8.GetString(byt); // 복호화
        }
    }
    class StringConverterDemo
    {
        static void Main()
        {
            string s = "안녕하세요.";
            Console.WriteLine("[1] 원본: {0}", s);

            s = StringConverter.ConvertToSimpleEncoding(s); // 인코딩
            Console.WriteLine("[2] 인코딩: {0}", s);

            s = StringConverter.ConvertToSimpleDecoding(s); // 디코딩
            Console.WriteLine("[3] 디코딩: {0}", s); 
        }
    }
}
