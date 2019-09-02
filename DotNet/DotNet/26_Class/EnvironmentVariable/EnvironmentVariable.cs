// Environment 클래스의 주요 속성 또는 메서드를 사용하여 환경 변수 정보 읽어오기 
using System;

class EnvironmentVariable
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
