using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_部分类
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public partial class Person
    {
        private string _name; 
    }

    public partial class Person
    {
        public void Test()
        {
            _name = "他两就是一个类";
        }
    }
}
