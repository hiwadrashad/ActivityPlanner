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
    public class AttendeeDataService
    {
        private readonly HttpClient _httpClient;

        public AttendeeDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<IEnumerable<AttendeeDTO>> GetAll()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<AttendeeDTO>>
                (await _httpClient.GetStreamAsync($"api/attendee"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<AttendeeDTO> GetDetails(string id)
        {
            return await JsonSerializer.DeserializeAsync<AttendeeDTO>
                (await _httpClient.GetStreamAsync($"api/attendee/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<AttendeeDTO> Add(AttendeeDTO model)
        {
            var initialJson =
                new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/attendee", initialJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<AttendeeDTO>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task Update(AttendeeDTO model)
        {
            var initialJson =
                new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/attendee", initialJson);
        }

        public async Task Delete(string id)
        {
            await _httpClient.DeleteAsync($"api/attendee/{id}");
        }
    }
}
