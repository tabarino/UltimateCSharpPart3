using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class AsyncAwaitExamples
    {
        public async Task DownloadHtmlAsync(string url)
        {
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            using (var streamWriter = new StreamWriter($"/Users/itabarino/Downloads/result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        public async Task<string> GetStringAsync(string url)
        {
            var httpClient = new HttpClient();
            
            return await httpClient.GetStringAsync(url);
        }
    }
}
