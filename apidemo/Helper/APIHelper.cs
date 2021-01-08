using System.Net.Http;
using System.Net.Http.Headers;

namespace apidemo
{
    public static class APIHelper
    {
        public static HttpClient APIClient { get; set; } 
        public static void InitializeCLient()
        {
            APIClient = new HttpClient();
            APIClient.DefaultRequestHeaders.Accept.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
