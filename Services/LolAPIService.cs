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
            string apiKey = "RGAPI-278b0857-a6dd-45c2-9207-f840639ba0e6"; // Wstaw tutaj swój klucz API
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
