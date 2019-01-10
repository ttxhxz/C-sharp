using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_面向对象多态
{
    class Program
    {
        static void Main(string[] args)
        {
            //实现多态的3种手段：1、虚方法
            Chinese c1 = new Chinese("韩梅梅");
            Chinese c2 = new Chinese("李雷");

            Japanese j1 = new Japanese("敬边子");
            Japanese j2 = new Japanese("树下军");

            Korea k1 = new Korea("金秀贤");
            Korea k2 = new Korea("金钟国");

            American a1 = new American("科比布莱恩");
            American a2 = new American("奥尼尔");

            Person[] pers = { c1, c2, j1, j2, k1, k2, a1, a2 };

            foreach (var item in pers)
            {
                item.SayHello();
            }

            Console.ReadKey();

        }
    }

    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }

    public class Chinese : Person
    {
        public Chinese(string name) : base(name)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine("我是中国人，我叫{0}", this.Name);
        }
    }

    public class Japanese : Person
    {
        public Japanese(string name) : base(name)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine("我是日本人，我叫{0}", this.Name);
        }
    }

    public class Korea : Person
    {
        public Korea(string name) : base(name)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine("我是韩国人，我叫{0}", this.Name);
        }
    }

    public class American : Person
    {
        public American(string name) : base(name)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine("我是美国人，我叫{0}", this.Name);
        }
    }
}
