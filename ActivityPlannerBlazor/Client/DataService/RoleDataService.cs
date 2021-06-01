using ActivityPlannerBlazor.Client.Interfaces;
using ActivityPlannerBlazor.Shared.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ActivityPlannerBlazor.Client.DataService
{
    public class RoleDataService : IRoleDataService
    {
        private readonly HttpClient _httpClient;

        public RoleDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<RoleDTO> GetCurrentRole()
        {
            return await JsonSerializer.DeserializeAsync<RoleDTO>
            (await _httpClient.GetStreamAsync($"api/roles"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

    }
}
