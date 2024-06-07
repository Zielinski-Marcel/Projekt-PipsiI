using PoroCounter2.Models;
using System.Text.Json;

namespace PoroCounter2.Services
{
    public class LolAPIService
    {
        private readonly HttpClient _httpClient;

        public LolAPIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PlatformData> GetPlatformDataAsync()
        {
            string apiKey = "RGAPI-bebc8ce0-630e-4c42-8e75-6a3a50ed21ba"; // Wstaw tutaj swój klucz API
            string url = $"https://eun1.api.riotgames.com/lol/status/v4/platform-data?api_key={apiKey}";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var platformData = JsonSerializer.Deserialize<PlatformData>(jsonResponse, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return platformData;
        }
    }
}
