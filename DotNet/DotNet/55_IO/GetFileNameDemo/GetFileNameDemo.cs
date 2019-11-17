using System;

class GetFileNameDemo
{
    static void Main()
    {
        //[Q] 아래 전체 경로가 입력되었을 때 파일명과 확장자 추출      
        //[1] Input
        string dir = "C:\\Website\\RedPlus\\images\\test.gif";
        string fullName = String.Empty;
        string name = "";
        string ext = name;

        //[2] Process
        // 전체파일명: 마지막 \\ 위치값 + 1한 위치부터 마지막까지 검색
        fullName = dir.Substring(dir.LastIndexOf('\\') + 1);
        name = fullName.Substring(0, fullName.LastIndexOf('.'));
        ext = fullName.Substring(fullName.LastIndexOf('.') + 1);

        //[3] Output
        Console.WriteLine($"전체 파일명: {fullName}");
        Console.WriteLine($"순수 파일명: {name}");
        Console.WriteLine($"확장자: {ext}");
    }
}
