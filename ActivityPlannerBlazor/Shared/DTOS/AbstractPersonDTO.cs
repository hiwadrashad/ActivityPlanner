using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ActivityPlannerBlazor.Shared.DTOS
{
    public abstract class AbstractPersonDTO
    {
        [Key]
        public virtual string id { get; set; }
        public virtual PersonalDataDTO Data { get; set; } = new PersonalDataDTO();
    }
}
