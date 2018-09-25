using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_转义字符
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("今天天气好晴朗\n处处好风光");

            //Console.WriteLine("我想在这句话中输出一个\"\"英文半角双引号");

            //string name1 = "张三";
            //string name2 = "李敏镐西都敏俊西老赵西";
            //string name3 = "不爱抽不舒服斯基";
            //string name4 = "井边溪上床下枕头边君";
            //Console.WriteLine("{0}\t\t\t{1}", name1, name2);
            //Console.WriteLine("{0}\t{1}", name3, name4);

            //将字符串按照原格式输出
            string str = @"佛挡杀佛是浮生的
法第三方士大夫士大夫";
            Console.WriteLine(str);


            Console.ReadKey();
        }
    }
}
