using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1
{
    class NormalStrategy : IBillingStrategy
    {
        public double GetActPrice(double rawPrice)
        {
            return rawPrice;
        }
    }
}
