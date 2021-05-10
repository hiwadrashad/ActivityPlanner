using ActivityPlannerBlazor.Client.Interfaces;
using ActivityPlannerBlazor.Shared.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ActivityPlannerBlazor.Client.DataService
{
    public class OrganizerDataService :IOrganizerDataService
    {
        private readonly HttpClient _httpClient;

        public OrganizerDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<IEnumerable<OrganizerDTO>> GetAll()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<OrganizerDTO>>
                (await _httpClient.GetStreamAsync($"api/organizer"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<OrganizerDTO> GetDetails(string id)
        {
            return await JsonSerializer.DeserializeAsync<OrganizerDTO>
                (await _httpClient.GetStreamAsync($"api/organizer/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<OrganizerDTO> Add(OrganizerDTO model)
        {
            var initialJson =
                new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/organizer", initialJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<OrganizerDTO>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task Update(OrganizerDTO model)
        {
            var initialJson =
                new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/organizer", initialJson);
        }

        public async Task Delete(string id)
        {
            await _httpClient.DeleteAsync($"api/organizer/{id}");
        }
    }
}
