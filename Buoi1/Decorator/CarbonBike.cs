using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class CarbonBike:IBike
    {
        public double GetPrice()
        {
            return 1000;
        }
        public string GetDetails()
        {
            return "Carbon";
        }

    }
}
