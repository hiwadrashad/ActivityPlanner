using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityPlannerBlazor.Shared.DTOS
{
    public class OrganizerDTO : AbstractPersonDTO
    {
        public List<AppointmentDTO> Appointments { get; set; }
        public List<AttendeeDTO> Acquaintances { get; set; }
        public List<string> Messages { get; set; }
        public List<AppointmentDTO> PassedAcceptanceRateAppointments { get; set; }
    }
}
