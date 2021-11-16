using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    interface Worker
    {
        string ten(string ten);
        string chucVu(string chucVu);
        void showDetails();
        double sumPrice(string chucVu);
        int countName(string ten);

    }
}
