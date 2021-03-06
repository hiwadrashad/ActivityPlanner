using ActivityPlannerBlazor.Shared.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityPlannerBlazor.Repo.Interfaces
{
    public interface ICurrentUser
    {
        OrganizerDTO GetCurrentOrganizer();
        OrganizerDTO UpdateCurrentOrganizer(OrganizerDTO item);
        AttendeeDTO GetCurrentAttendee();
        AttendeeDTO UpdateCurrentAttendee(AttendeeDTO item);
    }
}
