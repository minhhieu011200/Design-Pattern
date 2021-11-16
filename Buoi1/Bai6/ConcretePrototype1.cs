using System;
using System.Collections.Generic;
using System.Text;

namespace Bai6
{
    class ConcretePrototype1 : Prototype
    {
        public int age;
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }

    }
}
