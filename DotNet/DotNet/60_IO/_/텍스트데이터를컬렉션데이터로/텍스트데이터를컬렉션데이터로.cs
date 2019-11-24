using System;
using System.Collections.Generic;

class 텍스트데이터를컬렉션데이터로
{
    static void Main(string[] args)
    {
        // 텍스트 파일 읽기
        //string src = System.IO.File.ReadAllText(@"C:\Temp\src.txt");
        //string[] lines = System.IO.File.ReadAllLines(@"C:\Temp\src.txt");
        string[] lines =
            System.IO.File.ReadAllLines(
                @"C:\Temp\src.txt", System.Text.Encoding.Default);
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }

        // 문자열 배열의 정보를 컬렉션 형태의 개체에 담기
        List<Record> records = new List<Record>();
        foreach (var line in lines)
        {
            string[] splitData = line.Split(',');
            records.Add(
                new Record
                {
                    Name = splitData[0],
                    PhoneNumber = splitData[1],
                    BirthDate = Convert.ToDateTime(splitData[2]),
                    AuthCode = splitData[3]
                });
        }

        Console.WriteLine(records[0].Name);
    }
}
