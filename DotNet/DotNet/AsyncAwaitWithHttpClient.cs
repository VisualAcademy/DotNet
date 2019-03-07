using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

class AsyncAwaitWithHttpClient
{
    static void Main()
    {
        // 
    }

    static async Task DoAsync()
    {
        try
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://www.google.com");

                var content = await response.Content.ReadAsStreamAsync();
            }
        }
        catch (WebException ex) when (ex.Status == WebExceptionStatus.Timeout)
        {
            // 다시 요청
        }
    }
}
