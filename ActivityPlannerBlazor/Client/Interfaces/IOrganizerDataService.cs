using ActivityPlannerBlazor.Shared.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityPlannerBlazor.Client.Interfaces
{
    public interface IOrganizerDataService
    {
        Task<IEnumerable<OrganizerDTO>> GetAll();
        Task<OrganizerDTO> GetDetails(string id);
        Task<OrganizerDTO> Add(OrganizerDTO model);
        Task Update(OrganizerDTO model);
        Task Delete(string id);
    }
}
