using System;
using System.IO;

class FileReadString
{
    static void Main()
    {
        try
        {
            using (StreamReader sr = new StreamReader("example.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("파일을 열 수 없습니다.");
            Console.WriteLine(e.Message);
        }
    }
}
