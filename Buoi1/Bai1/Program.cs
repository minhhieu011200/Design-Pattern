using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            var normalStrategy = new NormalStrategy();
            var happyHourStrategy = new HappyHourStrategy();

            var firstCustomer = new CustomerBill(normalStrategy);
            firstCustomer.Add(1.0, 1);
            firstCustomer.Strategy = happyHourStrategy;
            firstCustomer.Add(1.0, 2);
            firstCustomer.Print();

            CustomerBill secondCustomer = new CustomerBill(happyHourStrategy);
            secondCustomer.Add(0.8, 1);
            secondCustomer.Strategy = normalStrategy;
            secondCustomer.Add(1.3, 2);
            secondCustomer.Add(2.5, 1);
            secondCustomer.Print();

        }
    }
}
