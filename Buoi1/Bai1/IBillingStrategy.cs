using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1
{
    interface IBillingStrategy
    {
        double GetActPrice(double rawPrice);
    }
}
