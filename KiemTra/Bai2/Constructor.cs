using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    class Constructor : Worker
    {
        private long id;
        private int workingDay;
        private int salaryPerDay;
        private double baseSalary;

        string name;

        public Constructor(long id, string name, int workingDay, int salaryPerDay, int baseSalary)
        {
            this.id = id;
            this.name = name;
            this.workingDay = workingDay;
            this.salaryPerDay = salaryPerDay;
            this.baseSalary = baseSalary;
        }

        public double sumPrice(string chucVu)
        {
            return baseSalary + workingDay * salaryPerDay;
        }
        public void showDetails()
        {
            Console.WriteLine(this.GetType().Name + ": ");
            Console.WriteLine(id + " " + name + " " + workingDay + " " + salaryPerDay + " " + baseSalary);
        }
        public string chucVu(string chucVu)
        {
            return "Constructor";
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
