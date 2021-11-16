using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var basicBike = new AluminiumBike();

            SecurityPackage upgraded = new SecurityPackage(basicBike);

            Console.WriteLine($"Bike: '{upgraded.GetDetails()}' Cost:{ upgraded.GetPrice()} ");
        }
    }
}
