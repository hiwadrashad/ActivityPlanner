using ActivityPlannerBlazor.Repo.Interfaces;
using ActivityPlannerBlazor.Shared.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivityPlannerBlazor.Repo.Repos
{
    public class MockingRepo : IMockingRepo
    {
        private List<AppointmentDTO> _appointments;
        private List<AttendeeDTO> _attendees;
        private List<OrganizerDTO> _organizers;

        private static MockingRepo _mockingRepo;

        private MockingRepo()
        {

        }

        public static MockingRepo GetMockingRepo()
        {
            if (_mockingRepo == null)
            {
                _mockingRepo = new MockingRepo();
                _mockingRepo.InitData();
            }

            return _mockingRepo;
        }

        private void InitData()
        {
            _organizers = new List<OrganizerDTO>
            {
               new OrganizerDTO()
               {
                   id = Guid.NewGuid().ToString(),
                   Data = new PersonalDataDTO()
                   {
                    Email = "test@hotmail.com",
                    Name = "test",
                    PostalCode = "test",
                    StreetName = "test",
                    StreetNumber = "test",
                    TelephoneNumber = "test"
                   },
                  Appointments = new List<AppointmentDTO>
                  {
                    new AppointmentDTO
                    {

                    }
                  }
               }
            };

            _attendees = new List<AttendeeDTO>();
            _organizers = new List<OrganizerDTO>();
        }

        public bool AddAppointment(AppointmentDTO DTO)
        {
            DTO.id = Guid.NewGuid().ToString();
            _appointments.Add(DTO);
            return true;
        }

        public bool AddAttendee(AttendeeDTO DTO)
        {
            DTO.id = Guid.NewGuid().ToString();
            _attendees.Add(DTO);
            return true;
        }

        public bool AddOrganizer(OrganizerDTO DTO)
        {
            DTO.id = Guid.NewGuid().ToString();
            _organizers.Add(DTO);
            return true;
        }

        public AppointmentDTO AddAppointmentAndReturnModel(AppointmentDTO DTO)
        {
            DTO.id = Guid.NewGuid().ToString();
            _appointments.Add(DTO);
            return DTO;
        }

        public AttendeeDTO AddAttendeeAndReturnModel(AttendeeDTO DTO)
        {
            DTO.id = Guid.NewGuid().ToString();
            _attendees.Add(DTO);
            return DTO;
        }

        public OrganizerDTO AddOrganizerAndreturnModel(OrganizerDTO DTO)
        {
            DTO.id = Guid.NewGuid().ToString();
            _organizers.Add(DTO);
            return DTO;
        }

        public bool DeleteAppointment(string id)
        {
            _appointments.Remove(_appointments.Where(a => a.id == id).FirstOrDefault());
            return true;
        }

        public bool DeleteAttendee(string id)
        {
            _attendees.Remove(_attendees.Where(a => a.id == id).FirstOrDefault());
            return true;
        }

        public bool DeleteOrganizer(string id)
        {
            _organizers.Remove(_organizers.Where(a => a.id == id).FirstOrDefault());
            return true;
        }

        public List<AppointmentDTO> GetAllAppointments()
        {
            return _appointments;
        }

        public List<AttendeeDTO> GetAllAttendees()
        {
            return _attendees;
        }

        public List<OrganizerDTO> GetAllOrganizers()
        {
            return _organizers;
        }

        public AppointmentDTO GetAppointment(string id)
        {
            return _appointments.Where(a => a.id == id).FirstOrDefault();
        }

        public AttendeeDTO GetAttendee(string id)
        {
            return _attendees.Where(a => a.id == id).FirstOrDefault();
        }

        public OrganizerDTO GetOrganizer(string id)
        {
            return _organizers.Where(a => a.id == id).FirstOrDefault();
        }

        public bool UpdateAppointment(AppointmentDTO DTO)
        {
            var ItemToUpdate = _appointments.Where(a => a.id == DTO.id).FirstOrDefault();
            ItemToUpdate.id = DTO.id;
            ItemToUpdate.AcceptanceRate = DTO.AcceptanceRate;
            ItemToUpdate.AcceptedOrNot = DTO.AcceptedOrNot;
            ItemToUpdate.ApproximateDate = DTO.ApproximateDate;
            ItemToUpdate.Attendees = DTO.Attendees;
            ItemToUpdate.Category = DTO.Category;
            ItemToUpdate.Description = DTO.Description;
            ItemToUpdate.EndDate = DTO.EndDate;
            ItemToUpdate.Location = DTO.Location;
            ItemToUpdate.MainOrganizer = DTO.MainOrganizer;
            ItemToUpdate.Name = DTO.Name;
            ItemToUpdate.Organizers = DTO.Organizers;
            ItemToUpdate.StartDate = DTO.StartDate;
            return true;
        }

        public bool UpdatAttendee(AttendeeDTO DTO)
        {
            var ItemToUpdate = _attendees.Where(a => a.id == DTO.id).FirstOrDefault();
            ItemToUpdate.id = DTO.id;
            ItemToUpdate.AcceptedInvites = DTO.AcceptedInvites;
            ItemToUpdate.Data = DTO.Data;
            ItemToUpdate.NotAcceptedInvites = DTO.NotAcceptedInvites;
            return true;
        }

        public bool UpdateOrganizer(OrganizerDTO DTO)
        {
            var ItemToUpdate = _organizers.Where(a => a.id == DTO.id).FirstOrDefault();
            ItemToUpdate.id = DTO.id;
            ItemToUpdate.Data = DTO.Data;
            ItemToUpdate.Appointments = DTO.Appointments;
            return true;
        }
    }
}
