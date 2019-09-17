using System;

class 환경변수
{
    static void Main()
    {
        Console.WriteLine(Environment.SystemDirectory); // 시스템폴더
        Console.WriteLine(Environment.Version); // 닷넷기준버전: 4.0.30319.42000
        Console.WriteLine(Environment.OSVersion); // 운영체제 버전
        Console.WriteLine(Environment.MachineName); // 컴퓨터명
        Console.WriteLine(Environment.UserName); // 사용자명
        Console.WriteLine(Environment.CurrentDirectory); // 현재 폴더
        Console.WriteLine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments)); // 내문서 폴더
    }
}
