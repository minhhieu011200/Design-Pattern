using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    class Director : Worker
    {

        private long id;
        private int workingDay;
        private int salaryPerDay;
        private double bonus;
        string name;

        public Director(long id, string name, int workingDay, int salaryPerDay, double bonus)
        {
            this.id = id;
            this.name = name;
            this.workingDay = workingDay;
            this.salaryPerDay = salaryPerDay;
            this.bonus = bonus;
        }

        public double sumPrice(string chucVu) { 
            return workingDay* salaryPerDay *(1 + bonus);
        } 

        public void showDetails()
        {
            Console.WriteLine(this.GetType().Name.ToString() + ": ");
            Console.WriteLine(id + " " + name + " " + workingDay + " " + salaryPerDay + " " + bonus);
        }

        public string chucVu(string chucVu)
        {
            return "Director";
        }

        public int countName(string ten)
        {
            if (ten == name)
            {
                return 1;
            }
            return 0;
        }

        public string ten(string ten)
        {
            return name;
        }
    }
}
