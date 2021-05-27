using ActivityPlannerBlazor.Shared.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityPlannerBlazor.Client.Interfaces
{
    public interface DIAttendeeDataService
    {
        Task<IEnumerable<AttendeeDTO>> GetAll();
        Task<AttendeeDTO> GetDetails(string id);
        Task<AttendeeDTO> Add(AttendeeDTO model);
        Task Update(AttendeeDTO model);
        Task Delete(string id);
    }
}
