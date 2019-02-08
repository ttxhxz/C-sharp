using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_移动存储设备
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileDisk md = new MobileDisk();
            MP3 mp3 = new MP3();
            UDisk u = new UDisk();

            Computer cpu = new Computer();
            cpu.Fd = mp3;
            cpu.CpuRead();
            cpu.CpuWrite();


            Console.ReadKey();

        }
    }

    public class Computer
    {
        public FatherDisk Fd
        {
            get;
            set;
        }

        public void CpuRead()
        {
            this.Fd.Read();
        }

        public void CpuWrite()
        {
            this.Fd.Write();

        }
    }

    public abstract class FatherDisk
    {
        public abstract void Read();
        public abstract void Write();
    }

    public class MobileDisk : FatherDisk
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘的读取");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘的写入");

        }
    }

    public class UDisk : FatherDisk
    {
        public override void Read()
        {
            Console.WriteLine("U盘的读取");
        }

        public override void Write()
        {
            Console.WriteLine("U盘的写入");

        }
    }

    public class MP3 : FatherDisk
    {
        public void PlayMusic()
        {
            Console.WriteLine("MP3可以自己播放音乐");

        }

        public override void Read()
        {
            Console.WriteLine("MP3的读取");
        }

        public override void Write()
        {
            Console.WriteLine("MP3的写入");

        }
    }
}
