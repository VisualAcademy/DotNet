using System;
using System.IO;

class 파일처리_텍스트파일읽기
{
    static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(@"C:\Temp\Test.txt");
        Console.WriteLine("{0}", sr.ReadToEnd()); // 전체 읽어오기
        sr.Close();
        sr.Dispose();
    }
}
