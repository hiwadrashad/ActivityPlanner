using ActivityPlannerBlazor.Shared.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityPlannerBlazor.Repo.Interfaces
{
    public interface IMockingRepo
    {
        bool AddAppointment(AppointmentDTO DTO);
        bool AddAttendee(AttendeeDTO DTO);
        bool AddOrganizer(OrganizerDTO DTO);
        AppointmentDTO AddAppointmentAndReturnModel(AppointmentDTO DTO);
        AttendeeDTO AddAttendeeAndReturnModel(AttendeeDTO DTO);
        OrganizerDTO AddOrganizerAndreturnModel(OrganizerDTO DTO);
        bool DeleteAppointment(string id);
        bool DeleteAttendee(string id);
        bool DeleteOrganizer(string id);
        List<AppointmentDTO> GetAllAppointments();
        List<AttendeeDTO> GetAllAttendees();
        List<OrganizerDTO> GetAllOrganizers();
        AppointmentDTO GetAppointment(string id);
        AttendeeDTO GetAttendee(string id);
        OrganizerDTO GetOrganizer(string id);
        bool UpdateAppointment(AppointmentDTO DTO);
        bool UpdatAttendee(AttendeeDTO DTO);
        bool UpdateOrganizer(OrganizerDTO DTO);
    }
}
