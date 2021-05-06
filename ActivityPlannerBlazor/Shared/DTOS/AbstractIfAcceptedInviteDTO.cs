using ActivityPlannerBlazor.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityPlannerBlazor.Shared.DTOS
{
    public abstract class AbstractIfAcceptedInviteDTO
    {
        public virtual Category Category { get; set; }
        public virtual bool Accepted { get; set; }
    }
}
