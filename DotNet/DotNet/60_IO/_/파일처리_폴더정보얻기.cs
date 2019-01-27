using System;
using System.IO;

class 파일처리_폴더정보얻기
{
    static void Main(string[] args)
    {
        string dir = "C:\\";

        // Directory 클래스
        if (Directory.Exists(dir))
        {
            // C 드라이브의 모든 폴더 목록을 출력
            foreach (string folder in Directory.GetDirectories(dir))
            {
                Console.WriteLine("{0}", folder);
            }
        }

        // DirectoryInfo 클래스
        DirectoryInfo di = new DirectoryInfo(dir + "Temp\\");
        if (di.Exists)
        {
            // C 드라이브의 Temp 폴더의 모든 파일 목록 출력
            foreach (var item in di.GetFiles())
            {
                Console.WriteLine("{0}", item);
            }
        }
    }
}
