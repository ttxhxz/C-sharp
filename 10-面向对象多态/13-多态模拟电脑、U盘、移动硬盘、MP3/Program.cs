using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_多态模拟电脑_U盘_移动硬盘_MP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //MobileDisk ms = new MobileDisk();
            //UDisk ud = new UDisk();
            //MP3 mp3 = new MP3();
            //Computer cpu = new Computer();
            //cpu.CpuRead(ms);
            //cpu.CpuWrite(ms);

            //MobileStorage ms = new MP3();
            //Computer cpu = new Computer();
            //cpu.CpuRead(ms);
            //cpu.CpuWrite(ms);

            MobileStorage ms = new UDisk();
            Computer cpu = new Computer();
            cpu.Ms = ms;
            cpu.CpuRead();
            cpu.CpuWrite();

            Console.ReadKey();

        }
    }

    public abstract class MobileStorage
    {
        public abstract void Read();

        public abstract void Write();
    }

    public class MobileDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘正在读取数据。");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘正在写入数据。");

        }
    }

    public class UDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘正在读取数据。");
        }

        public override void Write()
        {
            Console.WriteLine("U盘正在写入数据。");
        }
    }

    public class MP3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3正在读取数据。");
        }

        public override void Write()
        {
            Console.WriteLine("MP3正在写入数据。");
        }

        public void PlayMusic()
        {
            Console.WriteLine("MP3正在播放音乐");
        }
    }

    public class Computer
    {
        private MobileStorage _ms;
        public MobileStorage Ms
        {
            get { return _ms; }
            set { _ms = value; }
        }

        //public void CpuRead(MobileStorage ms)
        public void CpuRead()
        {
            Ms.Read();
        }

        //public void CpuWrite(MobileStorage ms)
        public void CpuWrite()
        {
            Ms.Write();
        }
    }
}
