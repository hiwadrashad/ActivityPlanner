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
        }

        public OrganizerDTO GetCurrentOrganizer()
        {
            return CurrentOrganizer;
        }

        public OrganizerDTO UpdateCurrentOrganizer(OrganizerDTO item)
        {
            _currentstaticuser.CurrentOrganizer.Acquaintances = item.Acquaintances;
            _currentstaticuser.CurrentOrganizer.Appointments = item.Appointments;
            _currentstaticuser.CurrentOrganizer.Data = item.Data;
            _currentstaticuser.CurrentOrganizer.id = item.id;
            return CurrentOrganizer;
        }
    }
}
