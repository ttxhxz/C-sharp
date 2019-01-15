using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_超市收银系统
{
    /// <summary>
    /// 买M送N
    /// </summary>
    class CalMN : CalFather
    {
        public double M
        {
            get;
            set;
        }

        public double N
        {
            get;
            set;
        }


        public CalMN(double m, double n)
        {
            this.M = m;
            this.N = n;
        }

        public override double GetTotalMoney(double realMoney)
        {
            if (realMoney >= this.M)
            {
                realMoney = realMoney - (int)(realMoney / M) * N;
            }
            return realMoney;
        }
    }
}
