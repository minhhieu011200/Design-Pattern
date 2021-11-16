using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class AluminiumBike:IBike
    {
        public double GetPrice()
        {
            return 100;
        }
        public string GetDetails()
        {
            return "Aluminium Bike";
        }

    }
}
