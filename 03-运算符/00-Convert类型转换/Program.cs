using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Convert类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //让用户输入姓名语文数学英语三门课的成绩，
            //然后给用户显示：XX，你的总成绩为xx分，平均成绩为xx分。
            Console.WriteLine("请输入你的姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入你的语文成绩");
            string strChinese = Console.ReadLine();
            Console.WriteLine("请输入你的数学成绩");
            string strMath = Console.ReadLine();
            Console.WriteLine("请输入你的英语成绩");
            string strEnglish = Console.ReadLine();
            //由于字符串去相加的话，最终会变成相连接，如果要拿字符串类型的变量参与计算
            //需要将字符串转换成int或者double类型
            int chinese = Convert.ToInt32(strChinese);
            int math = Convert.ToInt32(strMath);
            int english = Convert.ToInt32(strEnglish);
            int sum = chinese + math + english;
            float avg = sum / 3.0f;

            Console.WriteLine("{0}你的总成绩是{1}，平均成绩是{2}", name, sum, avg);


            Console.ReadKey();

        }
    }
}
