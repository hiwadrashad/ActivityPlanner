using ActivityPlannerBlazor.Client.Interfaces;
using ActivityPlannerBlazor.Shared.DTOS;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityPlannerBlazor.Client.Pages
{
    public partial class AppointmentOverview
    {
        [Inject]
        public ICurrentOrganizerDataService CurrentOrganizerDataService { get; set; }

        [Inject]
        public IOrganizerDataService OrganizerDataService { get; set; }

        [Inject]
        public IAttendeeDataService AttendeeDataService { get; set; }

        public OrganizerDTO CurrentOrganizer { get; set; } = new OrganizerDTO() { };

        protected override async Task OnInitializedAsync()
        {
            CurrentOrganizer = await CurrentOrganizerDataService.GetCurrentUser();
        }
    }
}
