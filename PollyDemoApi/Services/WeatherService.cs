
using System.Net.Http;
using System.Threading.Tasks;

namespace PollyDemoApi.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;
        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetWeatherAsync()
        {
            // Simulate unreliable external API (e.g. httpstat.us)
            var response = await _httpClient.GetAsync("https://httpstat.us/503");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}