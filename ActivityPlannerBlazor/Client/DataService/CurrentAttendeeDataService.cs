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
    public class CurrentAttendeeDataService : ICurrentAttendeeDataService
    {
        private readonly HttpClient _httpClient;

        public CurrentAttendeeDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<AttendeeDTO> GetCurrentUser()
        {
            return await JsonSerializer.DeserializeAsync<AttendeeDTO>
                (await _httpClient.GetStreamAsync($"api/currentattendee"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task Update(AttendeeDTO model)
        {
            var initialJson =
                new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("api/currentattendee", initialJson);
        }
    }
}
