using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _06_序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //要将序列化对象的类标记为可以被序列化的

            //序列化
            //Person p = new Person();
            //p.Name = "张三";
            //p.Age = 110;
            //p.Gender = '中';

            //using(FileStream fsWriter=new FileStream(@"C:\Users\liuwe\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fsWriter, p);
            //}
            //Console.WriteLine("序列化成功");

            //反序列化
            Person p;
            using (FileStream fsReader = new FileStream(@"C:\Users\liuwe\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                p = (Person)bf.Deserialize(fsReader);
            }
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Gender);


            Console.ReadKey();

        }
    }

    [Serializable]
    public class Person
    {
        public string Name
        {
            get;
            set;
        }

        public char Gender
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }
    }
}
