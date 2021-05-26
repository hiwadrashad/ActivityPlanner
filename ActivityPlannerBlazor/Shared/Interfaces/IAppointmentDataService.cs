using ActivityPlannerBlazor.Shared.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityPlannerBlazor.Client.Interfaces
{
    public interface IAppointmentDataService
    {
        Task<IEnumerable<AppointmentDTO>> GetAll();
        Task<AppointmentDTO> GetDetails(string id);
        Task<AppointmentDTO> Add(AppointmentDTO model);
        Task Update(AppointmentDTO model);
        Task Delete(string id);
    }
}
