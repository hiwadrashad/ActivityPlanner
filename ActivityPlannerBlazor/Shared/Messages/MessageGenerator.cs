using ActivityPlannerBlazor.Shared.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityPlannerBlazor.Shared.Messages
{
    public class MessageGenerator
    {
        public static string ReturnMessage(OrganizerDTO organizer, AppointmentDTO appointment)
        {
            return $"{organizer.Data.Name} invited you to come join her {appointment.Name} appointment, log in at https://activityplanner.com to accept the invite";
        }
    }
}
