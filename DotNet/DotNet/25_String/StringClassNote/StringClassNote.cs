using System;
using static System.Console;

class StringClassNote
{
    static void Main()
    {
        // str 변수에 테스트 문자열 설정
        string str = "";        // 빈 값으로 초기화
        str = String.Empty;     // 빈 값으로 초기화
        str = " Abc Def Fed Cba "; // 앞뒤 공백 한자씩 추가하여 17자

        WriteLine(str); // 전체 문자열 출력
        WriteLine(str.Length); // 17
        WriteLine(str[6 - 1]); // D
        WriteLine(str.ToUpper()); // 대문자
        WriteLine(str.ToLower()); // 소문자

        // 공백 제거 
        WriteLine(str.Trim());      // 양쪽 공백 제거
        WriteLine(str.TrimStart()); // 왼쪽 공백 제거
        WriteLine(str.TrimEnd());   // 오른쪽 공백 제거

        // 변환
        WriteLine(str.Replace("Def", "디이에프"));

        // 메서드 체이닝(체인)
        WriteLine(
            str.Replace("Def", "디이에프").Replace("Fed", "XYZ").ToLower());

        // 검색
        WriteLine(str.IndexOf('e')); // 6번째 인덱스에 위치
        WriteLine(str.LastIndexOf('e')); // 10번째 인덱스에 위치
        WriteLine(str.Substring(5, 3)); // 5번째 인덱스에서부터 3자 반환
        WriteLine(str.Substring(5)); // 5번째이후로 모두 가져오기 
        WriteLine(str.Remove(5, 3)); // 5번째 인덱스에서부터 3자 삭제하고 출력

        // 비교
        WriteLine(str[2 - 1] == str[16 - 1]); // A == a => false
        WriteLine(String.Compare("A", "C")); // 0(같음), 1(다름>), -1(다름<)
        WriteLine("A".CompareTo("C")); // A < C : -1
        WriteLine("Abc".Equals("Abc")); // True
        WriteLine(String.Equals("Abc", "aBC")); // False

        WriteLine("http://www.dotnetkorea.com".StartsWith("http")); // true
        WriteLine("http://www.dotnetkorea.com".EndsWith(".com")); // true

        var hi1 = "안녕";
        var hi2 = "하세요.";

        WriteLine(hi1 + hi2);
        WriteLine(String.Concat(hi1, hi2));
        WriteLine(String.Format("{0} {1} {0}", hi1, hi2));
        WriteLine($"{hi1} {hi2}");

        WriteLine(String.Format("{0:C}", 1000)); // 통화량
        WriteLine(String.Format("{0:#,###}", 1000)); // 세자리 콤마

        string[] strArray = str.Trim().Split(' ');
        foreach (string s in strArray)
        {
            WriteLine($"{s}");
        }
    }
}
