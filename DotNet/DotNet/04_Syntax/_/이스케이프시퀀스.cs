using System;

public class 이스케이프시퀀스
{
    public static void Main()
    {
        // \n: 줄바꿈
        Console.WriteLine("안녕\n하세요.");
        // \t: 탭만큼 들여쓰기
        Console.WriteLine("반갑\t습니다.");
        // \r: 캐리지리턴: 줄 맨 앞으로... -> \r\n
        Console.Write("또 만나요.\r");
        Console.WriteLine();
        // \': 작은따옴표 문자 하나 표현
        Console.WriteLine(" '낼' \'만나요.\' ");
        // \": 큰따옴표 문자 하나 표현
        Console.WriteLine(" \"어디\"에서요? ");
        // \\: 백(역)슬래시(\) 기호 자체를 표현
        Console.WriteLine(" \\: 백슬래시 표현");
        // 백슬래시 다음에 나오는 문자 하나는 이스케이프 문자로 본다.
        Console.WriteLine(" C:\\Home\\DevLec\\Default.aspx ");
        // 문자열 앞에 @ 기호를 붙이면 공백/탭 포함 문자열 자체로 본다.
        Console.WriteLine(@"

            안녕하세요.
            반갑습니다.
        
        ");
        // 더 많은 문자 이스케이스는 MSDN 온라인 사이트
        // (http://www.microsoft.com/korea/msdn/)에서 검색해서 사용

        Console.Read(); // 키 입력 대기
    }
}
