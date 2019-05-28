using System;
using System.Net;
using System.Threading;

namespace WebClientDemo
{
    class WebClientDemo
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();

            // 동기적으로 출력
            string google = client.DownloadString("http://www.google.co.kr");
            Console.WriteLine("Google: " + google.Substring(0, 20)); // 20자만 가져오기

            string naver = client.DownloadString(new Uri("http://www.naver.com"));
            Console.WriteLine("Naver: " + naver.Substring(0, 20));

            // 비동기적으로 출력
            client.DownloadStringAsync(new Uri("http://www.devlec.com"));
            client.DownloadStringCompleted += Client_DownloadStringCompleted;
            Thread.Sleep(3000); // 잠시 대기
        }

        private static void Client_DownloadStringCompleted(object sender, 
            DownloadStringCompletedEventArgs e)
        {
            Console.WriteLine($"DevLec: {e.Result.Substring(0, 20)}");
        }
    }
}
