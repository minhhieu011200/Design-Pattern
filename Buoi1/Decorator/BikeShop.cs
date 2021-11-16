using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class BikeShop
    {
        public static void UpgradeBike()
        {
            var basicBike = new AluminiumBike();
            BikeAccessories upgraded = new SportPackage(basicBike);
            upgraded = new SecurityPackage(upgraded);
            Console.WriteLine($"Bike: '{upgraded.GetDetails()}' Cost:{ upgraded.GetPrice()} ");
        }
    }

}
