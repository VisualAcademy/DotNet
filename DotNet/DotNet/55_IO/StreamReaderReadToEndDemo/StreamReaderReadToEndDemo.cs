using System;
using System.IO;

class StreamReaderReadToEndDemo
{
    static void Main()
    {
        //[1] StreamReader 클래스로 텍스트 파일 읽기
        StreamReader sr = new StreamReader(@"C:\Temp\Test.txt");

        //[2] ReadToEnd() 메서드로 텍스트 파일의 내용 읽어 콘솔에 출력하기 
        Console.WriteLine("{0}", sr.ReadToEnd()); // 전체 읽어오기

        //[3] 사용 후 파일 닫고 메모리 정리하기 
        sr.Close(); 
        sr.Dispose();
    }
}
