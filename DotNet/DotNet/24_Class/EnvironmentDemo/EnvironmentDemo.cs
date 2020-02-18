//[?] Environment 클래스
using System;

class EnvironmentDemo
{
    static void Main()
    {
        // 시스템폴더: C:\Windows\system32
        Console.WriteLine(Environment.SystemDirectory);
        // 닷넷기준버전: 4.0.30319.42000
        Console.WriteLine(Environment.Version);
        // 운영체제 버전: Microsoft Windows NT 6.2.9200.0
        Console.WriteLine(Environment.OSVersion);
        // 컴퓨터명: VISUALACADEMY
        Console.WriteLine(Environment.MachineName);
        // 사용자명: RedPlus
        Console.WriteLine(Environment.UserName);
        // 현재 폴더: C:\C#\EnvironmentDemo\EnvironmentDemo\bin\Debug
        Console.WriteLine(Environment.CurrentDirectory);
        // 문서 폴더: C:\Users\RedPlus\Documents
        string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        Console.WriteLine(docs);
    }
}
