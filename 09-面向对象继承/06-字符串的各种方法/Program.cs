using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_字符串的各种方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习一：随机输入你心中想到的一个名字，然后输出它的字符串长度Length：可以得字符串的长度
            //Console.WriteLine("请输入你心中想的那个人的名字");
            //string name = Console.ReadLine();
            //Console.WriteLine("你心中想的人的名字的长度是{0}", name.Length);
            //Console.ReadKey();

            //练习二：两个学员输入各自最喜欢的课程名称，判断是否一致，
            //如果相等，则输出你们俩喜欢相同的课程.
            //如果不相同，则输出你们俩喜欢不相同的课程.
            //Console.WriteLine("请输入你喜欢的课程：");
            //string lessonOne = Console.ReadLine();
            ////lessonOne = lessonOne.ToLower();

            //Console.WriteLine("请输入你喜欢的课程：");
            //string lessonTwo = Console.ReadLine();
            ////lessonTwo = lessonTwo.ToLower();

            //if (lessonOne.Equals(lessonTwo, StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("你们两喜欢的课程相同");
            //}
            //else
            //{
            //    Console.WriteLine("你们两喜欢的课程不同");
            //}

            //string s = "a b fds  _ +  = , , .  .Fdf";
            //char[] chs = { ' ', '_', '+', '=', ',' ,'.'};
            //string[] str = s.Split(chs, StringSplitOptions.RemoveEmptyEntries);

            //练习：从日期字符串（“2008-08-08"）中分析出年、月、日；2008年08月08日。
            //让用户输入一个日期格式如：2008-01-02.你输出你输入的日期为2008年1月2日]

            //string s = "1995-10-27";
            //string[] date = s.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("你输入的日期为{0}年{1}月{2}日", date[0], date[1], date[2]);

            //string str = "国家关键人物老赵";
            //if (str.Contains("老赵"))
            //{
            //    str = str.Replace("老赵", "**");
            //}
            //Console.WriteLine(str);

            //Substring 截取字符串
            //string str = "今年天气好晴朗，处处好风光";
            //str = str.Substring(1,2);
            //Console.WriteLine(str);


            ////LastIndexof Substring
            //string path = @"c:\a\b\c苍\d\e苍\f\g\\fd\fd\fdf\d\vfd\苍老师苍.wav";
            //int index = path.LastIndexOf("\\");
            //path = path.Substring(index + 1);
            //Console.WriteLine(path);

            //string str = "       ahhaah        ";
            //str = str.Trim();
            //Console.WriteLine(str);

            string[] names = { "张三", "李四", "王五", "赵六", "田七" };
            //张三|李四|王五|赵六|田七
            string newStr = string.Join("|", names);
            Console.WriteLine(newStr);

            Console.ReadKey();


        }
    }
}
