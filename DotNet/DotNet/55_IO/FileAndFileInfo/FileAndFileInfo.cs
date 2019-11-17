using System;
using System.IO;

class FileAndFileInfo
{
    static void Main()
    {
        string file = "C:\\Temp\\Test.txt";

        //[1] File 클래스: 정적 멤버 제공
        if (File.Exists(file)) // 파일이 있다면.
        {
            Console.WriteLine("{0}", File.GetCreationTime(file));
            File.Copy(file, "C:\\Temp\\Test2.txt", true); // 파일 복사 테스트
        }

        //[2] FileInfo 클래스: 인스턴스 멤버 제공
        FileInfo fi = new FileInfo(file);
        if (fi.Exists) // 파일이 존재한다면,
        {
            Console.WriteLine($"{fi.FullName}"); // 파일명 출력
        }
    }
}
