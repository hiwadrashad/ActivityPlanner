using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityPlannerBlazor.Shared.DTOS
{
    public class MessageDTO
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public AttendeeDTO From { get; set; }
    }
}
