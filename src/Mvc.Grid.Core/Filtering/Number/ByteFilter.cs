using System;

namespace NonFactors.Mvc.Grid
{
    public class ByteFilter : NumberFilter
    {
        public override Object GetNumericValue()
        {
            if (Byte.TryParse(Value, out byte number))
                return number;

            return null;
        }
    }
}
