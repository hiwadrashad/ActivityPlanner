using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityPlannerBlazor.Shared.DTOS
{
    public class NotAcceptedInviteDTO : AbstractIfAcceptedInviteDTO
    {
        public override bool Accepted { get; set; } = false;
        public AppointmentDTO Appointment { get; set; }
    }
}
