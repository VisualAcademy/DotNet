using System;
using System.IO;

class FileWriteString
{
    static void Main()
    {
        Console.Write("저장할 문자열을 입력하세요: ");
        string str = Console.ReadLine();

        try
        {
            using (StreamWriter file = new StreamWriter("example.txt"))
            {
                file.Write(str);
            }
            Console.WriteLine("파일에 저장되었습니다.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("파일을 열 수 없습니다. 에러: " + ex.Message);
        }
    }
}
