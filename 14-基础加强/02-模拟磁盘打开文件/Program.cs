using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_模拟磁盘打开文件
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要进入的磁盘：");
            string path = Console.ReadLine();
            Console.WriteLine("请输入一个文件名：");
            string fileName = Console.ReadLine();
            FileFather ff = GetFile(fileName, path + fileName);
            ff.OpenFile();


        }

        public static FileFather GetFile(string fileName, string fullPath)
        {
            FileFather ff = null;
            string extension = Path.GetExtension(fileName);
            switch (extension)
            {
                case ".txt":
                    ff = new TxtFile(fullPath);
                    break;
                case ".jpg":
                    ff = new JpgFile(fullPath);
                    break;
                case ".flv":
                    ff = new FlvFile(fullPath);
                    break;
            }
            return ff;
        }
    }

    public abstract class FileFather
    {
        public string FullPath
        {
            get;
            set;
        }

        public FileFather(string fullPath)
        {
            this.FullPath = fullPath;
        }

        public abstract void OpenFile();
    }

    public class TxtFile : FileFather
    {
        public TxtFile(string fullPath) : base(fullPath)
        {

        }

        public override void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(this.FullPath);
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();

        }
    }

    public class JpgFile : FileFather
    {
        public JpgFile(string fullPath) : base(fullPath)
        {

        }

        public override void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(this.FullPath);
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();

        }
    }

    public class FlvFile : FileFather
    {
        public FlvFile(string fullPath) : base(fullPath)
        {

        }

        public override void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(this.FullPath);
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();

        }
    }
}
