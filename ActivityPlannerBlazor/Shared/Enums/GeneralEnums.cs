using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityPlannerBlazor.Shared.Enums
{
    [Flags]
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    [Flags]
    public enum Category
    {
        Excersise,
        Travel,
        Diner,
        Relationship,
        Work,
        Study,
        Party,
        Other
    }
}
