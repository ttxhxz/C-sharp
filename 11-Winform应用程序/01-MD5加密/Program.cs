using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _01_MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            //123
            //202cb962ac59075b964b07152d234b70
            //Console.WriteLine("请输入一个字符串进行md5加密：");
            //string input = Console.ReadLine();



            string s = GetMD5("123");
            Console.WriteLine(s);
            Console.WriteLine("202cb962ac59075b964b07152d234b70");
            //double n = 123.456;
            //Console.WriteLine(n.ToString("c"));

            Console.ReadKey();

        }

        public static string GetMD5(string str)
        {
            //创建MD5对象
            MD5 md5 = MD5.Create();
            //开始加密
            //需要将字符串转换成字节数组
            byte[] buffer = Encoding.Default.GetBytes(str);
            //返回一个加密好的字节数组
            byte[] MD5Buffer = md5.ComputeHash(buffer);

            //将字节数组中的每个元素ToString();
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < MD5Buffer.Length; i++)
            {
                sBuilder.Append(MD5Buffer[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        static bool VerifyMd5Hash(string input, string hash)
        {
            //输入的Hash
            string hashOfInput = GetMD5(input);
            // 创建一个StringComparer并比较哈希值。
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
