using System;

public class 문자열관련클래스데모
{
    public static void Main()
    {
        string str = "";
        str = String.Empty;
        str = " Abc Def Fed Cba ";

        Console.WriteLine(str);
        Console.WriteLine(str[6 - 1]); // D
        Console.WriteLine(str.Length); // 길이 : Len()

        Console.WriteLine(str.ToUpper()); // 대문자
        Console.WriteLine(str.ToLower()); // 소문자
        Console.WriteLine("[{0}]", str.TrimStart());     // 왼쪽 공백 제거
        Console.WriteLine("[{0}]", str.TrimEnd());       // 오른쪽 공백 제거
        Console.WriteLine("[{0}]", str.Trim());          // 양쪽 공백 제거
        Console.WriteLine(str.Trim().Length); // 15

        Console.WriteLine(
            str.Replace("Def", "디이에프").Replace("에프", "F"));

        Console.WriteLine(str.IndexOf('z')); // -1
        Console.WriteLine(str.IndexOf("e")); // 6
        Console.WriteLine(str.LastIndexOf('e')); // 

        Console.WriteLine(str.Substring(5, 3));
        Console.WriteLine(str.Substring(5));
        Console.WriteLine(str.Remove(5, 3));

        string[] strArray = str.Trim().Split(' ');
        foreach (string s in strArray)
        {
            Console.WriteLine("{0}", s);
        }

        Console.WriteLine(str[2 - 1] == str[16 - 1]); // A == a => false
        Console.WriteLine(String.Compare("A", "C")); // 0(같음), 1(다름>), -1(다름<)
        Console.WriteLine("A".CompareTo("C")); // A < C : -1
        Console.WriteLine("Abc".Equals("Abc")); // True
        Console.WriteLine(String.Equals("Abc", "aBC")); // False

        Console.WriteLine("http://www.devlec.com".StartsWith("http"));
        Console.WriteLine("http://www.devlec.com".EndsWith(".com"));

        string Hi1 = "안녕";
        string Hi2 = "하세요.";

        Console.WriteLine(Hi1 + Hi2);
        Console.WriteLine(String.Concat(Hi1, Hi2));
        Console.WriteLine(String.Format("{0} {1} {0}", Hi1, Hi2));

        Console.WriteLine(String.Format("{0:C}", 1000)); // 통화량
        Console.WriteLine(String.Format("{0:#,###}", 1000)); // 세자리 콤마
    }
}
