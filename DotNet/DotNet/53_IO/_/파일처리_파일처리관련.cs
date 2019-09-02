using System;
using System.IO;

class 파일처리_파일처리관련
{
    static void Main(string[] args)
    {
        // 내 문서 폴더 값 가져오기
        string myDoc =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        Console.WriteLine(myDoc);

        string myFile = myDoc + @"\MyFile1.txt";
        string myFile2 = myDoc + @"\MyFile2.txt";

        // 내 문서 폴더에 특정 파일이 있으면 확인, 그렇지 않으면 파일 생성
        if (File.Exists(myFile))
        {
            Console.WriteLine("파일이 없습니다.");
        }
        else
        {
            File.Create(myFile);
            if (File.Exists(myFile))
            {
                Console.WriteLine("파일이 생성되었습니다.");
            }
        }

        // 파일 복사 또는 이동
        if (File.Exists(myFile))
        {
            Console.WriteLine(File.GetCreationTime(myFile));
            Console.WriteLine("복사중...");
            // 파일 복사
            File.Copy(myFile, myFile2);

            //Console.WriteLine("이동중...");
            // 파일 이동
            //File.Move(myFile, myDoc + @"\MyFile3.txt");
        }
    }
}
