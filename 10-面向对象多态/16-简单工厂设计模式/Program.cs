using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你想要的品牌电脑：");
            string brand = Console.ReadLine();

            NoteBook nb = GetNoteBook(brand);
            nb.SayHello();
            Console.ReadKey();

        }

        /// <summary>
        /// 简单工厂的核心 根据用户的输入创建对象赋值给父类
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public static NoteBook GetNoteBook(string brand)
        {
            NoteBook nb = null;
            switch (brand)
            {
                case "Lenovo":
                    nb = new Lenovo();
                    break;
                case "IBM":
                    nb = new IBM();
                    break;
                case "Acer":
                    nb = new Acer();
                    break;
                case "DELL":
                    nb = new DELL();
                    break;
                case "SAMSUNG":
                    nb = new SAMSUNG();
                    break;
            }
            return nb;
        }
    }

    public abstract class NoteBook
    {
        public abstract void SayHello();
    }

    public class Lenovo : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是联想笔记本");
        }
    }

    public class IBM : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是IBM笔记本");
        }
    }
    public class Acer : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是宏碁（qī）笔记本");
        }
    }
    public class DELL : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是戴尔笔记本");
        }
    }
    public class SAMSUNG : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是三星笔记本");
        }
    }

}
