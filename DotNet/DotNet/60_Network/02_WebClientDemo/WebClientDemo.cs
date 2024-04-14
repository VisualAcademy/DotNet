using System;
using System.Net;
using System.Threading;

class WebClientDemo
{
    static void Main()
    {
        WebClient client = new WebClient();

        // 구글 웹 페이지의 내용을 동기적으로 다운로드하고 처음 10자만 출력
        string google = client.DownloadString("http://www.google.co.kr");
        Console.WriteLine("Google: " + google.Substring(0, 10)); // 처음 10자만 출력

        // 네이버 웹 페이지의 내용을 동기적으로 다운로드하고 처음 10자만 출력
        string naver = client.DownloadString(new Uri("http://www.naver.com"));
        Console.WriteLine("Naver: " + naver.Substring(0, 10));

        // 비동기적으로 웹 페이지 다운로드 시작
        client.DownloadStringAsync(new Uri("http://www.dotnetkorea.com"));
        client.DownloadStringCompleted += Client_DownloadStringCompleted;
        Thread.Sleep(3000); // 메인 스레드를 3초간 대기시킴
    }

    private static void Client_DownloadStringCompleted(object sender,
        DownloadStringCompletedEventArgs e)
    {
        // 다운로드 완료 후 결과에서 줄바꿈을 제거하고 처음 10자만 출력
        string r = e.Result.Replace("\n", "").Substring(0, 10);
        Console.WriteLine($"DotNetKorea: {r}");
    }
}
