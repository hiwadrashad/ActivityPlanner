using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityPlannerBlazor.Shared.DTOS
{
    public class OrganizerDTO : AbstractPersonDTO
    {
        public List<AppointmentDTO> Appointments { get; set; }
    }
}
