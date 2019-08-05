using System;

class 문자열관련클래스
{
    static void Main(string[] args)
    {
        string str = "";        // 빈 값으로 초기화
        str = String.Empty;     // 빈 값으로 초기화
        str = " Abc Def Fed Cba "; // 17자

        Console.WriteLine(str);
        Console.WriteLine(str.Length); // 17
        Console.WriteLine(str[6 - 1]); // D
        Console.WriteLine(str.ToUpper()); // 대문자
        Console.WriteLine(str.ToLower()); // 소문자

        Console.WriteLine(str.Trim());      // 양쪽 공백 제거
        Console.WriteLine(str.TrimStart()); // 왼쪽 공백 제거
        Console.WriteLine(str.TrimEnd());   // 오른쪽 공백 제거

        // 변환
        Console.WriteLine(
            str
                .Replace("Def", "디이에프")
                .Replace("Fed", "XYZ").ToLower()); // 메서드 체이닝(체인)

        // 검색
        Console.WriteLine(str.IndexOf('e')); // 6번째 인덱스에 위치
        Console.WriteLine(str.LastIndexOf('e')); // 10번째 인덱스에 위치
        Console.WriteLine(str.Substring(5, 3)); // 5번째 인덱스에서부터 3자 반환
        Console.WriteLine(str.Substring(5)); // 5번째이후로 모두 가져와라~
        Console.WriteLine(
            str.Remove(5, 3)); // 5번째 인덱스에서부터 3자 삭제하고 출력

        Console.WriteLine(
            "http://www.dotnetkorea.com".StartsWith("http")); // true
        Console.WriteLine(
            "http://www.dotnetkorea.com".EndsWith(".com")); // true
    }
}
