using ActivityPlannerBlazor.Shared.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityPlannerBlazor.Shared.ViewModels
{
    public class AppointmentViewmodel
    {
        public AppointmentDTO appointment { get; set; }
        public List<AttendeeDTO> choiceofattendees { get; set; }
    }
}
