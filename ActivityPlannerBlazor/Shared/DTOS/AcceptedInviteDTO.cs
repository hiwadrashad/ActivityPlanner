using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityPlannerBlazor.Shared.DTOS
{
    public class AcceptedInviteDTO : AbstractIfAcceptedInviteDTO
    {
        public override bool Accepted { get; set; } = true;
        public AppointmentDTO Appointment { get; set; }
    }
}
