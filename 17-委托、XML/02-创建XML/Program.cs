using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _02_创建XML
{
    class Program
    {
        static void Main(string[] args)
        {
            //通过代码来创建XML文档
            //1、引用命名空间
            //2、创建XML文档对象
            XmlDocument doc = new XmlDocument();
            //3、创建第一行描述信息，并且添加到doc文档中
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            //4、创建根节点
            XmlElement books = doc.CreateElement("Books");
            doc.AppendChild(books);

            //5、给根节点books创建子节点
            XmlElement book1 = doc.CreateElement("Book");
            //将book添加到根节点
            books.AppendChild(book1);
            XmlElement book2 = doc.CreateElement("Book");
            //将book添加到根节点
            books.AppendChild(book2);
            XmlElement book3 = doc.CreateElement("Book");
            //将book添加到根节点
            books.AppendChild(book3);

            //6、给Book1添加子节点
            XmlElement name1 = doc.CreateElement("Name");
            name1.InnerText = "金瓶梅";
            book1.AppendChild(name1);
            XmlElement price1 = doc.CreateElement("Price");
            price1.InnerText = "10";
            book1.AppendChild(price1);
            XmlElement des1 = doc.CreateElement("Des");
            des1.InnerText = "好看";
            book1.AppendChild(des1);

            XmlElement name2 = doc.CreateElement("Name");
            name2.InnerText = "金瓶梅";
            book2.AppendChild(name2);
            XmlElement price2 = doc.CreateElement("Price");
            price2.InnerText = "10";
            book2.AppendChild(price2);
            XmlElement des2 = doc.CreateElement("Des");
            des2.InnerText = "好看";
            book2.AppendChild(des2);

            XmlElement name3 = doc.CreateElement("Name");
            name3.InnerText = "金瓶梅";
            book3.AppendChild(name3);
            XmlElement price3 = doc.CreateElement("Price");
            price3.InnerText = "10";
            book3.AppendChild(price3);
            XmlElement des3 = doc.CreateElement("Des");
            des3.InnerText = "好看";
            book3.AppendChild(des3);

            doc.Save("Books.xml");
            Console.WriteLine("保存成功");
            Console.ReadKey();

        }
    }
}
