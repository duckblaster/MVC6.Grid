using System;

namespace NonFactors.Mvc.Grid
{
    public class UInt16Filter : NumberFilter
    {
        public override Object GetNumericValue()
        {
            if (UInt16.TryParse(Value, out ushort number))
                return number;

            return null;
        }
    }
}
