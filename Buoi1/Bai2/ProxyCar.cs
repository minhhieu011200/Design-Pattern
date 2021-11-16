using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    class ProxyCar : ICar
    {
        private Driver driver;
        private Car realCar;
        public ProxyCar(Driver driver)
        {
            this.driver = driver;
            this.realCar = new Car();
        }

        public void DriveCar()
        {
            if (driver.Age < 16)
                Console.WriteLine("Sorry, the driver is too young to drive.");
            else
                this.realCar.DriveCar();

        }
    }
}
