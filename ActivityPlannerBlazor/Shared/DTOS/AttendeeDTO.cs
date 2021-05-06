using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityPlannerBlazor.Shared.DTOS
{
    public abstract class AttendeeDTO : AbstractPersonDTO
    {
        public List<AcceptedInviteDTO> AcceptedInvites { get; set; }
        public List<NotAcceptedInviteDTO> NotAcceptedInvites { get; set; }
    }
}
