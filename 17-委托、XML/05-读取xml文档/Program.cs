using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _05_读取xml文档
{
    class Program
    {
        static void Main(string[] args)
        {
            //XmlDocument doc = new XmlDocument();
            //doc.Load("Books.xml");

            ////获得根节点
            //XmlElement books = doc.DocumentElement;

            ////获得子节点
            //XmlNodeList xnl = books.ChildNodes;

            //foreach (XmlNode item in xnl)
            //{
            //    Console.WriteLine(item.InnerText);
            //}

            //读取带属性的XML文档
            //XmlDocument doc = new XmlDocument();
            //doc.Load("Books.xml");
            //XmlNodeList xnl = doc.SelectNodes("/Books/item/OrderItem");
            //foreach (XmlNode node in xnl)
            //{
            //    Console.WriteLine(node.Attributes["Name"].Value);
            //    Console.WriteLine(node.Attributes["Count"].Value);
            //}

            //删除节点
            XmlDocument doc = new XmlDocument();
            doc.Load("Books.xml");
            XmlNode xn = doc.SelectSingleNode("/Books/item");
            xn.RemoveAll();
            doc.Save("Books.xml");
            Console.WriteLine("删除成功");


            Console.ReadKey();

        }
    }
}
