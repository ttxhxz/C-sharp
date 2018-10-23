using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_枚举的练习
{
    enum QQState
    {
        OnLine,
        offLine,
        Leave,
        Busy,
        QMe
    }

    class Program
    {
        static void Main(string[] args)
        {
            QQState qQState = QQState.OnLine;
        }
    }
}
