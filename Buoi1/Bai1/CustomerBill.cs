using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1
{
    class CustomerBill
    {
        private List<double> drinks;
        public IBillingStrategy Strategy { get; set; }
        public CustomerBill(IBillingStrategy strategy)
        {
            this.drinks = new List<double>();
            this.Strategy = strategy;
        }
        public void Add(double price, int quantity)
        {
            drinks.Add(Strategy.GetActPrice(price * quantity));
        }
        // Payment of bill
        public void Print()
        {
            double sum = 0;
            foreach (var drinkCost in this.drinks)
            {
                sum += drinkCost;
            }
            Console.WriteLine($"Total due: {sum}.");
            this.drinks.Clear();
        }

    }
}
