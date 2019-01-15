using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_超市收银系统
{
    /// <summary>
    /// 抽象打折父类
    /// </summary>
    public abstract class CalFather
    {
        public abstract double GetTotalMoney(double realMoney);
    }
}
