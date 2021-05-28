using ActivityPlannerBlazor.Repo.Interfaces;
using ActivityPlannerBlazor.Repo.Repos;
using ActivityPlannerBlazor.Shared.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace ActivityPlannerBlazor.Server.StaticResources
{
    public class CurrentStaticUser : ICurrentUser
    {
        public IMockingRepo _repo = MockingRepo.GetMockingRepo();
        public OrganizerDTO CurrentOrganizer { get; set; }
        public AttendeeDTO CurrentAttendee { get; set; }

        private static CurrentStaticUser _currentstaticuser;

        private CurrentStaticUser()
        { 
        
        }

        public static  CurrentStaticUser GetCurrentStaticUser()
        {
            if (_currentstaticuser == null)
            {
                _currentstaticuser = new CurrentStaticUser();
                _currentstaticuser.InitData();
            }

            return _currentstaticuser;
        }

        private void InitData()
        {
            CurrentOrganizer = _repo.GetAllOrganizers().FirstOrDefault();
            CurrentAttendee = _repo.GetAllAttendees().FirstOrDefault();
        }

        public AttendeeDTO GetCurrentAttendee()
        {
            return CurrentAttendee;
        }
        public OrganizerDTO GetCurrentOrganizer()
        {
            return CurrentOrganizer;
        }

        public AttendeeDTO UpdateCurrentAttendee(AttendeeDTO item)
        {
            CurrentAttendee.AcceptedInvites = item.AcceptedInvites;
            CurrentAttendee.Data = item.Data;
            CurrentAttendee.id = item.id;
            CurrentAttendee.NotAcceptedInvites = item.NotAcceptedInvites;
            CurrentAttendee.password = item.password;
            CurrentAttendee.PendingInvites = item.PendingInvites;
            CurrentAttendee.Updates = item.Updates;
            return CurrentAttendee;
        }
        public OrganizerDTO UpdateCurrentOrganizer(OrganizerDTO item)
        {
            CurrentOrganizer.Acquaintances = item.Acquaintances;
            CurrentOrganizer.Appointments = item.Appointments;
            CurrentOrganizer.Data = item.Data;
            CurrentOrganizer.id = item.id;
            return CurrentOrganizer;
        }
    }
}
