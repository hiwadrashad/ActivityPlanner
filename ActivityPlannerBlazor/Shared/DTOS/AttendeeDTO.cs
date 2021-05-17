using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityPlannerBlazor.Shared.DTOS
{
    public class AttendeeDTO : AbstractPersonDTO
    {
        public List<AcceptedInviteDTO> AcceptedInvites { get; set; } = new List<AcceptedInviteDTO>();
        public List<NotAcceptedInviteDTO> NotAcceptedInvites { get; set; } = new List<NotAcceptedInviteDTO>();
        public List<PendingInviteDTO> PendingInvites { get; set; } = new List<PendingInviteDTO>();
        public List<string> Updates { get; set; } = new List<string>();
    }
}
