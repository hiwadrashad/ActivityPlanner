using ActivityPlannerBlazor.Client.Interfaces;
using ActivityPlannerBlazor.Shared.DTOS;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityPlannerBlazor.Client.Pages
{
    public partial class AppointmentDelete
    {
        //[Inject]
        //public ICurrentOrganizerDataService CurrentOrganizerDataService { get; set; }
        //[Inject]
        //public IAppointmentDataService AppointmentsDataService { get; set; }
        //[Inject]
        //public IOrganizerDataService OrganizersDataService { get; set; }
        //[Inject]
        //public NavigationManager navmanager { get; set; }

        //[Parameter]
        //public string id { get; set; }

        //public OrganizerDTO CurrentOrganizer { get; set; } = new OrganizerDTO() { };

        //public AppointmentDTO CurrentAppointment { get; set; } = new AppointmentDTO { };


        //protected override async Task OnInitializedAsync()
        //{
        //    CurrentOrganizer = await CurrentOrganizerDataService.GetCurrentUser(); ;
        //    CurrentAppointment = CurrentOrganizer.Appointments.Where(a => a.id == id).FirstOrDefault();
        //}

        //public async void DeleteAppointment()
        //{
        //    CurrentOrganizer.Appointments.Remove(CurrentAppointment);
        //    await CurrentOrganizerDataService.Update(CurrentOrganizer);
        //    await AppointmentsDataService.Delete(CurrentAppointment.id);
        //    await OrganizersDataService.Update(CurrentOrganizer);
        //    navmanager.NavigateTo("/succesfullydeletedappointment");

        //}
    }
}

