using ActivityPlannerBlazor.Client.Interfaces;
using ActivityPlannerBlazor.Shared.DTOS;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityPlannerBlazor.Client.Pages
{
    public partial class AppointmentEdit
    {
        //[Inject]
        //public ICurrentOrganizerDataService CurrentOrganizerDataService { get; set; }
        //[Inject]
        //public IAppointmentDataService AppointmentsDataService { get; set; }
        //[Inject]
        //public IOrganizerDataService OrganizersDataService { get; set; }

        //[Parameter]
        //public string id { get; set; }

        //public OrganizerDTO CurrentOrganizer { get; set; } = new OrganizerDTO() { };

        //public AppointmentDTO CurrentAppointment { get; set; } = new AppointmentDTO { };


        //protected override async Task OnInitializedAsync()
        //{
        //    CurrentOrganizer = await CurrentOrganizerDataService.GetCurrentUser(); ;
        //    CurrentAppointment = CurrentOrganizer.Appointments.Where(a => a.id == id).FirstOrDefault();
        //}

        //public void UpdateAppointment()
        //{
        //    CurrentOrganizer.Appointments.Where(a => a.id == id).FirstOrDefault().id = CurrentAppointment.id;
        //    CurrentOrganizer.Appointments.Where(a => a.id == id).FirstOrDefault().AcceptanceRate = CurrentAppointment.AcceptanceRate;
        //    CurrentOrganizer.Appointments.Where(a => a.id == id).FirstOrDefault().AcceptedOrNot = CurrentAppointment.AcceptedOrNot;
        //    CurrentOrganizer.Appointments.Where(a => a.id == id).FirstOrDefault().ApproximateDate = CurrentAppointment.ApproximateDate;
        //    CurrentOrganizer.Appointments.Where(a => a.id == id).FirstOrDefault().Attendees = CurrentAppointment.Attendees;
        //    CurrentOrganizer.Appointments.Where(a => a.id == id).FirstOrDefault().Category = CurrentAppointment.Category;
        //    CurrentOrganizer.Appointments.Where(a => a.id == id).FirstOrDefault().Description = CurrentAppointment.Description;
        //    CurrentOrganizer.Appointments.Where(a => a.id == id).FirstOrDefault().EndDate = CurrentAppointment.EndDate;
        //    CurrentOrganizer.Appointments.Where(a => a.id == id).FirstOrDefault().Location = CurrentAppointment.Location;
        //    CurrentOrganizer.Appointments.Where(a => a.id == id).FirstOrDefault().MainOrganizer = CurrentAppointment.MainOrganizer;
        //    CurrentOrganizer.Appointments.Where(a => a.id == id).FirstOrDefault().Name = CurrentAppointment.Name;
        //    CurrentOrganizer.Appointments.Where(a => a.id == id).FirstOrDefault().Organizers = CurrentAppointment.Organizers;
        //    CurrentOrganizer.Appointments.Where(a => a.id == id).FirstOrDefault().StartDate = CurrentAppointment.StartDate;
        //    CurrentOrganizerDataService.Update(CurrentOrganizer);
        //    OrganizersDataService.Update(CurrentOrganizer);
        //    AppointmentsDataService.Update(CurrentAppointment);

        //}

    }
}
