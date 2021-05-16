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
    public class CurrentOrganizerDataService : ICurrentOrganizerDataService
    {
        private readonly HttpClient _httpClient;

        public CurrentOrganizerDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task <OrganizerDTO> GetCurrentUser()
        {
            return await JsonSerializer.DeserializeAsync<OrganizerDTO>
                (await _httpClient.GetStreamAsync($"api/currentorganizer"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task Update(OrganizerDTO model)
        {
            var initialJson =
                new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/currentorganizer", initialJson);
        }
    }
}
