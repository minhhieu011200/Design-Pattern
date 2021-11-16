using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class BikeAccessories : IBike
    {
        private readonly IBike _bike;
        public BikeAccessories(IBike bike)
        {
            _bike = bike;
        }
        public virtual double GetPrice()
        {
            return _bike.GetPrice();
        }
        public virtual string GetDetails()
        {
            return _bike.GetDetails();
        }
    }

}
