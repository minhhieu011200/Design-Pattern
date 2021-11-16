using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1
{
    abstract class Prototype
    {
        public double weight { get; set; }
        public int quanlity { get; set; }
        public double price { get; set; }
        public string color { get; set; }

        public Prototype() { }
        public Prototype(double weight, int quanlity, double price, string color)
        {
            this.weight = weight;
            this.quanlity = quanlity;
            this.price = price;
            this.color = color;
        }

        public abstract void print();
        public abstract double harvest();
        public abstract double total();
    }
}
