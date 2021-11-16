using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    class Manager: Worker
    {
   
        private long id;
        private int workingDay;
        private int salaryPerDay;
        string name;

        public Manager(long id, string name, int workingDay, int salaryPerDay)
        {
            this.id = id;
            this.name = name;
            this.workingDay = workingDay;
            this.salaryPerDay = salaryPerDay;
        }

        public double sumPrice(string chucVu)
        {
           return workingDay* salaryPerDay;
        }
        public void showDetails()
        {
            Console.WriteLine(this.GetType().Name + ": ");
            Console.WriteLine(id + " " + name + " " + workingDay + " " + salaryPerDay);
        }

        public string chucVu(string chucVu)
        {
            return "Manager";
        }

        public int countName(string ten)
        {
            if(ten==name)
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
