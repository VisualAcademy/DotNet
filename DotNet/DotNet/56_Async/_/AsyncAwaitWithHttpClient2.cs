// 샘플 코드: 실행 안됨
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncAwaitWithHttpClient2
{
    class AsyncAwaitWithHttpClient2
    {
        static async Task Main()
        {
            Console.WriteLine("웹에서 문자열 가져오기");
            var mystring = await DoItAsync();

            Console.WriteLine(mystring);
        }

        private async static Task<string> DoItAsync()
        {
            var httpClient = new HttpClient();
            var message = await httpClient.GetAsync("Http://dotnetnote.com");
            var content = await message.Content.ReadAsStringAsync();
            return content;
        }
    }
}
