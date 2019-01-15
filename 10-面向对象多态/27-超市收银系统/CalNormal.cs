using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_超市收银系统
{
    class CalNormal : CalFather
    {
        /// <summary>
        /// 不打折
        /// </summary>
        /// <param name="realMoney"></param>
        /// <returns></returns>
        public override double GetTotalMoney(double realMoney)
        {
            return realMoney;
        }
    }
}
