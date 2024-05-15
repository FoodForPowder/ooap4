
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ooap4.Models;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace OOAP4.Service
{
    public class YaApi
    {
        public YaApi()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Yandex-API-Key", "f525e4a0-5fd3-4395-a2fa-0df5ff1bc78c");
        }
        HttpClient client;
        public async Task<Root> GetWeatherByPoint(double lat, double lon)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.weather.yandex.ru/v2/forecast/?lat={lat.ToString(CultureInfo.InvariantCulture)}&lon={lon.ToString(CultureInfo.InvariantCulture)}&lang=ru_RU&hours=false&limit=1");
            request.Headers.Add("X-Yandex-API-Key", "f525e4a0-5fd3-4395-a2fa-0df5ff1bc78c");

            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var jsonresponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Root>(jsonresponse);
            }

            return null;  

        }
    }
}
