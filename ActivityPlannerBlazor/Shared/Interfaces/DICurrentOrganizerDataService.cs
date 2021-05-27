using ActivityPlannerBlazor.Shared.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityPlannerBlazor.Client.Interfaces
{
    public interface DICurrentOrganizerDataService
    {
        Task<OrganizerDTO> GetCurrentUser();
        Task Update(OrganizerDTO model);
    }
}
