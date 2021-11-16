using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    class WorkerComposite : Worker
    {
        public Worker worker;
        public List<Worker> workerComposites;
        public string name;
        public WorkerComposite()
        {
            workerComposites = new List<Worker>();
        }

        public string chucVu(string chucVu)
        {
            return chucVu;
        }

        public string ten(string ten)
        {
            return name;
        }

        public void showDetails()
        {
            foreach (var work in workerComposites)
            {
                work.showDetails();
            }
        }

        public double sumPrice(string chucVu)
        {
            double luong = 0;
            foreach (var work in workerComposites)
            {
                if (chucVu == "all")
                {
                    luong += work.sumPrice(chucVu);
                }
                else if (chucVu == work.chucVu(chucVu))
                {
                    luong += work.sumPrice(chucVu);
                }
                 

            }
            return luong;
        }

        public int countName(string ten)
        {
            int countName = 0;
            foreach (var work in workerComposites)
            {
   
                if (ten == work.ten(ten))
                {
                    Console.WriteLine(work.ten(ten));
                    countName+=work.countName(ten);
                }


            }
            return countName;
        }

 
    }
}
