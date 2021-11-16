using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class SecurityPackage : BikeAccessories
    {
        public SecurityPackage(IBike bike) : base(bike)
        {
        }
        public override string GetDetails()
        {
            return base.GetDetails() + " + Security Package";
        }
        public override double GetPrice()
        {
            return base.GetPrice() + 1;
        }
    }
}
