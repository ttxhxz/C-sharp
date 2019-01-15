using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_超市收银系统
{
    class CalRate : CalFather
    {
        public double Rate
        {
            get;
            set;
        }

        /// <summary>
        /// 按照折扣率打折
        /// </summary>
        public CalRate(double rate)
        {
            this.Rate = rate;
        }

        public override double GetTotalMoney(double realMoney)
        {
            return realMoney * this.Rate;
        }
    }
}
