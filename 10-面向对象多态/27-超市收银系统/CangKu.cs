using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_超市收银系统
{
    class CangKu
    {
        List<List<ProductFather>> list = new List<List<ProductFather>>();

        //1ist[0]存储Acer电脑
        //1ist[1]存储三星手机
        //1ist[2]存储酱油
        //1ist[3]存储香蕉
        /// <summary>
        /// 在创建仓库对象时，向仓库中添加货架
        /// </summary>
        public CangKu()
        {
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }

        /// <summary>
        /// 向用户展示货物
        /// </summary>
        public void ShowPros()
        {
            foreach (var item in list)
            {
                Console.WriteLine("我们超市有:{0},\t有{1}个,\t每个{2}元。", item[0].Name, item.Count, item[0].Price);
            }
        }

        /// <summary>
        /// 向仓库进货
        /// </summary>
        /// <param name="itemType"></param>
        /// <param name="count"></param>
        public void JinPros(string itemType, int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (itemType)
                {
                    case "Acer":
                        list[0].Add(new Acer(Guid.NewGuid().ToString(), 1000, "宏碁笔记本"));
                        break;
                    case "SamSung":
                        list[1].Add(new SamSung(Guid.NewGuid().ToString(), 2000, "三星手机"));
                        break;
                    case "JiangYou":
                        list[2].Add(new JiangYou(Guid.NewGuid().ToString(), 10, "老抽酱油"));
                        break;
                    case "Banana":
                        list[3].Add(new Banana(Guid.NewGuid().ToString(), 50, "大香蕉"));
                        break;
                }
            }
        }

        /// <summary>
        /// 从仓库出货
        /// </summary>
        /// <param name="itemType"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public ProductFather[] QuPros(string itemType, int count)
        {
            ProductFather[] pros = new ProductFather[count];
            for (int i = 0; i < count; i++)
            {
                switch (itemType)
                {
                    case "Acer":
                        pros[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "SamSung":
                        pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "JiangYou":
                        pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "Banana":
                        pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                }
            }
            return pros;
        }
    }
}
