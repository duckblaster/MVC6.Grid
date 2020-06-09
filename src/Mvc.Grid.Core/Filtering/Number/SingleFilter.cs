using System;

namespace NonFactors.Mvc.Grid
{
    public class SingleFilter : NumberFilter
    {
        public override Object GetNumericValue()
        {
            if (Single.TryParse(Value, out float number))
                return number;

            return null;
        }
    }
}
