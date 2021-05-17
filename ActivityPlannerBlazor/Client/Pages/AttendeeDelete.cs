using ActivityPlannerBlazor.Client.Interfaces;
using ActivityPlannerBlazor.Shared.DTOS;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityPlannerBlazor.Client.Pages
{
    public partial class AttendeeDelete
    {
        //[Inject]
        //public ICurrentOrganizerDataService CurrentOrganizerDataService { get; set; }
        //[Inject]
        //public IAttendeeDataService AttendeeDataService { get; set; }
        //[Inject]
        //public IOrganizerDataService OrganizersDataService { get; set; }
        //[Inject]
        //public NavigationManager navmanager { get; set; }

        //[Parameter]
        //public string id { get; set; }

        //public OrganizerDTO CurrentOrganizer { get; set; } = new OrganizerDTO() { };

        //public AttendeeDTO CurrentAttendee { get; set; } = new AttendeeDTO { };


        //protected override async Task OnInitializedAsync()
        //{
        //    CurrentOrganizer = await CurrentOrganizerDataService.GetCurrentUser(); ;
        //    CurrentAttendee = CurrentOrganizer.Acquaintances.Where(a => a.id == id).FirstOrDefault();
        //}

        //public async void DeleteAppointment()
        //{
        //    CurrentOrganizer.Acquaintances.Remove(CurrentAttendee);
        //    var attendees = await AttendeeDataService.GetAll();
        //    var specificattendee = attendees.FirstOrDefault();
        //    specificattendee.Updates.Add($"{CurrentOrganizer.Data.Email} Removed you.");
        //    await CurrentOrganizerDataService.Update(CurrentOrganizer);
        //    await OrganizersDataService.Update(CurrentOrganizer);
        //    navmanager.NavigateTo("/succesfullydeletedappointment");

        //}
    }
}
