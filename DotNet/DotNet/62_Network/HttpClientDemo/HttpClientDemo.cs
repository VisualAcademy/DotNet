// HttpClientDemo 프로젝트에서 실행
using System;
using System.Net.Http;
using System.Threading.Tasks;

class HttpClientDemo
{
    static async Task Main()
    {
        //[1] HttpClient 개체 생성
        HttpClient httpClient = new HttpClient();

        //[2] GetAsync() 메서드 호출
        HttpResponseMessage httpResponseMessage = 
            await httpClient.GetAsync("http://www.dotnetnote.com/");

        //[3] HTML 가져오기 
        string responseBody = await httpResponseMessage.Content.ReadAsStringAsync();

        //[4] 출력
        Console.WriteLine(responseBody);
    }
}
