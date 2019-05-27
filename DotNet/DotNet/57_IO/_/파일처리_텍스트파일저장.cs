using System;
using System.IO;

class 파일처리_텍스트파일저장
{
    static void Main()
    {
        string data = 
            "안녕하세요.\r\n반가습니다." + Environment.NewLine + "또 만나요.";
        // StreamWriter 클래스를 사용하여 파일 생성
        // C 드라이브에 Temp 폴더 미리 생성해야 함
        StreamWriter sw = new StreamWriter("C:\\Temp\\Test.txt");
        // Write() 메서드 : 저장
        sw.WriteLine(data);
        // StreamWrite 개체를 생성했으면 반드시 닫기
        sw.Close();
        // 메모리 해제 
        sw.Dispose();
    }
}
