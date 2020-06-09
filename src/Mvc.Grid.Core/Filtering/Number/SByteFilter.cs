using System;

namespace NonFactors.Mvc.Grid
{
    public class SByteFilter : NumberFilter
    {
        public override Object GetNumericValue()
        {
            if (SByte.TryParse(Value, out sbyte number))
                return number;

            return null;
        }
    }
}
