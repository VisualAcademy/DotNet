using System;
using System.IO;

class CountLinesInTextFile
{
    static void Main()
    {
        try
        {
            // 파일을 읽기 모드로 열기
            using (StreamReader file = new StreamReader("example.txt"))
            {
                int lineCount = 0; // 줄 수를 저장할 변수
                string line; // 파일에서 읽은 문자열을 저장할 변수
                // 파일 끝(EOF)에 도달할 때까지 문자열을 하나씩 읽기
                while ((line = file.ReadLine()) != null)
                {
                    lineCount++; // 줄 수 증가
                }

                // 파일에 있는 줄 수를 출력
                Console.WriteLine("파일에 있는 줄 수: {0}", lineCount);
            }
        }
        catch (Exception e)
        {
            // 파일 열기 실패 시 오류 메시지 출력 후 종료
            Console.WriteLine("파일 열기 실패: {0}", e.Message);
        }
    }
}
