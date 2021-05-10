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
    public class AppointmentDataService : IAppointmentDataService
    {
        private readonly HttpClient _httpClient;

        public AppointmentDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<IEnumerable<AppointmentDTO>> GetAll()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<AppointmentDTO>>
                (await _httpClient.GetStreamAsync($"api/appointment"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<AppointmentDTO> GetDetails(string id)
        {
            return await JsonSerializer.DeserializeAsync<AppointmentDTO>
                (await _httpClient.GetStreamAsync($"api/appointment/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<AppointmentDTO> Add(AppointmentDTO model)
        {
            var initialJson =
                new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/appointment", initialJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<AppointmentDTO>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task Update(AppointmentDTO model)
        {
            var initialJson =
                new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/appointment", initialJson);
        }

        public async Task Delete(string id)
        {
            await _httpClient.DeleteAsync($"api/appointment/{id}");
        }
    }
}
