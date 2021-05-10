using ActivityPlannerBlazor.Client.Interfaces;
using ActivityPlannerBlazor.Shared.DTOS;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityPlannerBlazor.Client.Pages
{
    public partial class AddAcquaintances
    {
        //[Inject]
        //public ICurrentOrganizerDataService CurrentOrganizerDataService { get; set; }

        //[Inject]
        //public IOrganizerDataService OrganizerDataService { get; set; }

        //[Inject]
        //public IAttendeeDataService AttendeeDataService { get; set; }

        //public OrganizerDTO CurrentOrganizer { get; set; } = new OrganizerDTO() { };

        //public AttendeeDTO AttendeeToAdd { get; set; } = new AttendeeDTO();

        //protected override async Task OnInitializedAsync()
        //{
        //    CurrentOrganizer = await CurrentOrganizerDataService.GetCurrentUser(); 
        //}

        //public async void AddAcquaintance()
        //{
        //    var allattendees = await AttendeeDataService.GetAll();
        //    if (allattendees.Any(a => a.Data.Email == AttendeeToAdd.Data.Email) || allattendees.Any(a => a.Data.PostalCode == AttendeeToAdd.Data.PostalCode || allattendees.Any(a => a.Data.TelephoneNumber == AttendeeToAdd.Data.TelephoneNumber)))
        //    {
        //        CurrentOrganizer.Acquaintances.Add(AttendeeToAdd);
        //        await OrganizerDataService.Update(CurrentOrganizer);
        //    }
        //    else 
        //    {
        //        await AttendeeDataService.Add(AttendeeToAdd);
        //        CurrentOrganizer.Acquaintances.Add(AttendeeToAdd);
        //        await OrganizerDataService.Update(CurrentOrganizer);
        //    }
        //}
    }
}
