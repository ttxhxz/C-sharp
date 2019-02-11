using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _04_追加XML
{
    class Program
    {
        static void Main(string[] args)
        {
            //追加xml
            XmlDocument doc = new XmlDocument();
            //如果文件存在
            //如果文件不存在
            if (File.Exists("Books.xml"))
            {
                //如果文件存在 加载xml
                doc.Load("Books.xml");
                //获得文件的根节点
                XmlElement books = doc.DocumentElement;
            }
            else
            {
                //如果文件不存在
                //创建第一行
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(dec);
                //创建根节点
                XmlElement books = doc.CreateElement("Books");
                doc.AppendChild(books);
            }

        }
    }
}
