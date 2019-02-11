using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _03_创建带属性的XML文档
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            XmlElement order = doc.CreateElement("Order");
            doc.AppendChild(order);
            XmlElement customerName = doc.CreateElement("CustomerName");
            customerName.InnerText = "刘洋";
            order.AppendChild(customerName);

            XmlElement items = doc.CreateElement("Items");
            order.AppendChild(items);

            XmlElement orderItem1 = doc.CreateElement("orderItem1");
            //给节点添加属性
            orderItem1.SetAttribute("Name", "充气娃娃");
            orderItem1.SetAttribute("Count", "10");
            items.AppendChild(orderItem1);


            doc.Save("节点属性.xml");

            Console.WriteLine("保存成功");
            Console.ReadKey();

        }
    }
}
