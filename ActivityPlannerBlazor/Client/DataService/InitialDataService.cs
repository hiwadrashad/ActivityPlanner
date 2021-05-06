using ActivityPlannerBlazor.Client.Interfaces;
using ActivityPlannerBlazor.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ActivityPlannerBlazor.Client.DataService
{
    public class InitialDataService : IInitialDataService
    {
        private readonly HttpClient _httpClient;

        public InitialDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<IEnumerable<InitialModel>> GetAllInitials()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<InitialModel>>
                (await _httpClient.GetStreamAsync($"api/initial"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<InitialModel> GetInitialDetails(string id)
        {
            return await JsonSerializer.DeserializeAsync<InitialModel>
                (await _httpClient.GetStreamAsync($"api/initial/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<InitialModel> AddInitial(InitialModel model)
        {
            var initialJson =
                new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/initial", initialJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<InitialModel>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task UpdateInitial(InitialModel model)
        {
            var initialJson =
                new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/initial", initialJson);
        }

        public async Task DeleteInitial(string id)
        {
            await _httpClient.DeleteAsync($"api/initial/{id}");
        }
    }
}
