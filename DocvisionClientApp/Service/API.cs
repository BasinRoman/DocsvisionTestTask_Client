using Newtonsoft.Json.Linq;
using System.Text;


namespace DocsvisionClientApp.Service
{
    public static class API
    {
        //Get
        public  static async Task<JObject> ApiGet(string API)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7197/api/");
            HttpResponseMessage response = await client.GetAsync(API);
            string result = await response.Content.ReadAsStringAsync();
            dynamic data = JObject.Parse(result);
            return data;
        }

        //Post
        public static async Task<string> ApiPost(string API, string JsonString)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7197/api/");
            var content = new StringContent(JsonString, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(API, content);
            var responseAsString = await result.Content.ReadAsStringAsync();
            return responseAsString;
        }
    }
}

