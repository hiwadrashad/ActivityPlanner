using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityPlannerBlazor.Shared.ExtensionMethods
{
    public static class TupleExtensions
    {
           public static bool HasValue(this Tuple<string, string> tuple)
    {
        return !string.IsNullOrEmpty(tuple?.Item1) && !string.IsNullOrEmpty(tuple?.Item2);
    }
    }
}
