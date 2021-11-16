using System;
using System.Collections.Generic;
using System.Text;

namespace Bai6
{
     class ConcretePrototype2 : Prototype
    {
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();

        }
    }
    
}
