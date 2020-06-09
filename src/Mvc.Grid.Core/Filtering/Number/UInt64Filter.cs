﻿using System;

namespace NonFactors.Mvc.Grid
{
    public class UInt64Filter : NumberFilter
    {
        public override Object GetNumericValue()
        {
            if (UInt64.TryParse(Value, out ulong number))
                return number;

            return null;
        }
    }
}
