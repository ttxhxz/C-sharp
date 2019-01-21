using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_石头剪刀布
{
    class Computer
    {
        public string Fist
        {
            get;
            set;
        }

        public int ShowFist()
        {
            Random r = new Random();
            int cpuNumber = r.Next(1, 4);
            switch (cpuNumber)
            {
                case 1:
                    Fist = "石头";
                    break;
                case 2:
                    Fist = "剪刀";
                    break;
                case 3:
                    Fist = "布";
                    break;
            }
            return cpuNumber;
        }
    }
}
