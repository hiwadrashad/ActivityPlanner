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
        public string id { get; set; }
        [MaxLength(12)]
        public string Name { get; set; }
        [MaxLength(172)]
        public string Description { get; set; }
        [Display(Name = "Organizer")]
        public OrganizerDTO MainOrganizer { get; set; } = new OrganizerDTO();
        public List<OrganizerDTO> Organizers { get; set; } = new List<OrganizerDTO>();
        public List<AttendeeDTO> Attendees { get; set; } = new List<AttendeeDTO>();
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
        public Tuple<AttendeeDTO, bool> AcceptedOrNot { get; set; }
    }
}
