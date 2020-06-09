using System;

namespace NonFactors.Mvc.Grid
{
    public class Int16Filter : NumberFilter
    {
        public override Object GetNumericValue()
        {
            if (Int16.TryParse(Value, out short number))
                return number;

            return null;
        }
    }
}
