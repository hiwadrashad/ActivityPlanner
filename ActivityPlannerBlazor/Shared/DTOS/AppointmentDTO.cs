using ActivityPlannerBlazor.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ActivityPlannerBlazor.Shared.DTOS
{
    public class AppointmentDTO
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Display(Name = "Organizer")]
        public OrganizerDTO MainOrganizer { get; set; }
        public List<OrganizerDTO> Organizers { get; set; }
        public List<AttendeeDTO> Attendees { get; set; }
        [Display(Name = "Approximate date")]
        public Season ApproximateDate { get; set; }
        [Display(Name = "Starting date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Ending date")]
        public DateTime EndDate { get; set; }
        public Category Category { get; set; }
        public string Location { get; set; }
        [Display(Name = "Amount of acceptances for sending final notifications")]
        public int AcceptanceRate { get; set; }
        [Display(Name = "Accepted invite?")]
        public Dictionary<AttendeeDTO, bool> AcceptedOrNot { get; set; }
    }
}
