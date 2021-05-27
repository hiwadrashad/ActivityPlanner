using ActivityPlannerBlazor.Shared.DTOS;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting.WhiteBox
{
    public class InternalTests
    {
        AppointmentDTO appointment = new AppointmentDTO()
        {
            AcceptanceRate = 12,
            ApproximateDate = ActivityPlannerBlazor.Shared.Enums.Season.Autumn,
            AcceptedOrNot = new List<Tuple<AttendeeDTO, bool>>()
            { },
            Attendees = new List<AttendeeDTO>()
            { },
            Category = ActivityPlannerBlazor.Shared.Enums.Category.Diner,
            Description = "",
            EndDate = DateTime.Now,
            id = Guid.NewGuid().ToString(),
            Location = "",
            MainOrganizer = new OrganizerDTO()
            { },
            Name = "",
            Organizers = new List<OrganizerDTO>()
            { },
            StartDate = DateTime.Now
        };

        OrganizerDTO organizer = new OrganizerDTO()
        {
            Acquaintances = new List<AttendeeDTO>()
            { },
            Appointments = new List<AppointmentDTO>()
            { },
            Data = new PersonalDataDTO()
            { },
            id = Guid.NewGuid().ToString(),
            Messages = new List<MessageDTO>()
            { },
            PassedAcceptanceRateAppointments = new List<AppointmentDTO>()
            { }
        };

        AttendeeDTO attendee = new AttendeeDTO()
        {
            AcceptedInvites = new List<AcceptedInviteDTO>()
            { },
            Data = new PersonalDataDTO()
            { },
            id = Guid.NewGuid().ToString(),
            NotAcceptedInvites = new List<NotAcceptedInviteDTO>()
            { },
            PendingInvites = new List<PendingInviteDTO>()
            { },
            Updates = new List<string>()
            { }
        };

        [Test]
        [Category("Adding")]
        public void AddAppointment()
        {            
          
        }
        
    }
}
