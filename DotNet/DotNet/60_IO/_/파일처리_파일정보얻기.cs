using System;
using System.IO;

class 파일처리_파일정보얻기
{
    static void Main(string[] args)
    {
        string file = "C:\\Temp\\Test.txt";

        // File 클래스 : 정적
        if (File.Exists(file)) // 파일이 있다면.
        {
            Console.WriteLine("{0}", File.GetCreationTime(file));
            File.Copy(file, "C:\\Temp\\Test2.txt", true);
        }

        // FileInfo 클래스 : 인스턴스
        FileInfo fi = new FileInfo(file);
        if (fi.Exists) // 파일이 존재한다면,
        {
            Console.WriteLine("{0}", fi.FullName); // 파일명 출력
        }
    }
}
