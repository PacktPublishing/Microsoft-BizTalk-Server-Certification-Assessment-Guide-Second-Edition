using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter05_Example01.HelperLibrary
{
    public class CodeHelper
    {
        public static int CalculateOperationalRange(int fuelTankCapacity, decimal consumedLitersPerMile)
        {
            return Convert.ToInt32(Convert.ToDecimal(fuelTankCapacity) / consumedLitersPerMile);
        }
    }
}
