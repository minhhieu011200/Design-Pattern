using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new ProxyCar(new Driver(15));
            car.DriveCar();
            car = new ProxyCar(new Driver(25));
            car.DriveCar();
        }
    }
}
