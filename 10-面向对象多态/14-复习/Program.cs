using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_复习
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 泛型集合
             *List<T>
             *Dictionary<T，T>
             *装箱和拆箱
             *文件流
             *FileStream StreamReader和Streamuriter
             *多态：虚方法、抽象类、接口
             *虚方法：*抽象类：
          */

            //File FileStream StreamReader StreamWriter
            //相对路径
            //using (FileStream fs = new FileStream("520ssj.txt", FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    byte[] buffer = new byte[1024 * 1024 * 5];
            //    //本次读取实际读取到的字节数
            //    int r = fs.Read(buffer, 0, buffer.Length);

            //    //将字节数组中的每个元素按照我们制定的编码格式解析成字符串
            //    string str = Encoding.UTF8.GetString(buffer, 0, r);
            //    Console.WriteLine(str);

            //}

            //using (FileStream fs=new FileStream ("520ssj.txt",FileMode.OpenOrCreate,FileAccess.Write))
            //using (FileStream fs=new FileStream ("520ssj.txt",FileMode.Append,FileAccess.Write))//追加
            //{
            //    string s = "今天我们要学习好多好多东西";
            //    byte[] buffer = Encoding.UTF8.GetBytes(s);
            //    fs.Write(buffer, 0, buffer.Length);
            //}


            //老师可以起立  学生也可以起立 校长也可以起立
            //声明父类指向子类对象
            Person p = new HeadMaster();
            p.StandUp();


            Console.ReadKey();

        }
    }

    public abstract class Person
    {
        public abstract void StandUp();
    }

    public class Student : Person
    {
        public override void StandUp()
        {
            Console.WriteLine("学生起立，说老师好。");
        }
    }

    public class Teacher : Person
    {
        public override void StandUp()
        {
            Console.WriteLine("老师起立，说校长好。");
        }
    }

    public class HeadMaster : Person
    {
        public override void StandUp()
        {
            Console.WriteLine("校长起立，说领导好。");
        }
    }
}
