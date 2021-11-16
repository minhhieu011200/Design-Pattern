using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1
{
    class FruitJuice : Prototype
    {
        public FruitJuice() : base() { }

        public FruitJuice(double weight, int quanlity, double price, string color) : base(weight, quanlity, price, color) { }
        public override void print()
        {
            Prototype clone = (Prototype)this.MemberwiseClone();
            Console.WriteLine(clone.weight+ " " + clone.quanlity+" " + clone.price+ " " + clone.color+" ");
        }

        public override double harvest()
        {
            Prototype clone = (Prototype)this.MemberwiseClone();

            return clone.weight * clone.quanlity;
        }

        public override double total()
        {
            Prototype clone = (Prototype)this.MemberwiseClone();

            return clone.weight * clone.quanlity * clone.price;
        }

    }
}
