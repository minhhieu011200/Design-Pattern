using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1
{
    class HappyHourStrategy : IBillingStrategy
    {
        public double GetActPrice(double rawPrice)
        {
            return rawPrice*0.5;
        }
    }
}
