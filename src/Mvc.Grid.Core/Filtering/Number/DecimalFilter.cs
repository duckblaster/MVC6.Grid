using System;

namespace NonFactors.Mvc.Grid
{
    public class DecimalFilter : NumberFilter
    {
        public override Object GetNumericValue()
        {
            if (Decimal.TryParse(Value, out decimal number))
                return number;

            return null;
        }
    }
}
