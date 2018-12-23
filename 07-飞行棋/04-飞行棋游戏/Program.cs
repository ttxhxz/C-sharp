using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_飞行棋游戏
{
    class Program
    {
        //
        static int[] maps = new int[100];
        //声明一个静态
        static int[] playerPos = new int[2];
        //储存两个玩家的姓名
        static string[] playerNames = new string[2];
        //两个玩家的标记
        static bool[] Flags = new bool[2];//初始都是false

        static void Main(string[] args)
        {
            GameShow();
            #region 输入玩家姓名
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("请输入玩家A的姓名:");
            playerNames[0] = Console.ReadLine();
            while (playerNames[0] == "")
            {
                Console.WriteLine("玩家A的姓名不能为空，请重新输入:");
                playerNames[0] = Console.ReadLine();
            }

            Console.WriteLine("请输入玩家B的姓名:");
            playerNames[1] = Console.ReadLine();
            while (playerNames[1] == "" || playerNames[1] == playerNames[0])
            {
                if (playerNames[1] == "")
                {
                    Console.WriteLine("玩家A的姓名不能为空，请重新输入:");
                    playerNames[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("玩家A的姓名不能和玩家B的姓名相同，请重新输入:");
                    playerNames[1] = Console.ReadLine();
                }
            }
            #endregion
            //玩家姓名输入OK之后 我们首先应该清屏
            Console.Clear();
            GameShow();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("玩家:{0} 用A表示", playerNames[0]);
            Console.WriteLine("玩家:{0} 用B表示", playerNames[1]);
            //画地图之前 首先应该初始化地图
            InitailMap();
            DrawMap();

            //当玩家A和玩家B没有一个人在终点的时候，游戏继续
            while (playerPos[0] < 99 && playerPos[1] < 99)
            {
                if (Flags[0] == false)
                {
                    PlayGame(0);
                }
                else
                {
                    Flags[0] = false;
                }
                if (playerPos[0] >= 99)
                {
                    Console.WriteLine("玩家{0}赢了玩家{1}", playerNames[0], playerNames[1]);
                    break;
                }

                if (Flags[1] == false)
                {
                    PlayGame(1);
                }
                else
                {
                    Flags[1] = false;
                }
                if (playerPos[1] >= 99)
                {
                    Console.WriteLine("玩家{0}赢了玩家{1}", playerNames[1], playerNames[0]);
                    break;
                }

            }

            Win();
            Console.ReadKey();
        }

        /// <summary>
        /// 生成游戏头
        /// </summary>
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*************************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("*************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*****LoveSSJ的飞行棋*****");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************");
        }

        /// <summary>
        /// 初始化地图
        /// </summary>
        public static void InitailMap()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };//幸运轮盘。◎
            for (int i = 0; i < luckyturn.Length; i++)
            {
                maps[luckyturn[i]] = 1;
            }

            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//地雷☆
            for (int i = 0; i < landMine.Length; i++)
            {
                maps[landMine[i]] = 2;
            }

            int[] pause = { 9, 27, 60, 93 };//暂停▲
            for (int i = 0; i < pause.Length; i++)
            {
                maps[pause[i]] = 3;
            }

            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };//时空隧道卐
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                maps[timeTunnel[i]] = 4;
            }

        }

        /// <summary>
        /// 画地图
        /// </summary>
        public static void DrawMap()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("图例:幸运轮盘:◎\t地雷:☆\t暂停:▲\t时空隧道:卐");
            #region 第一横行
            for (int i = 0; i < 30; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            //画完第一行换行
            Console.WriteLine();
            #region 第一竖行
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    //两个半角空格等于一个全角字符或者符号
                    Console.Write("  ");
                }
                Console.WriteLine(DrawStringMap(i));
            }
            #endregion
            #region 第二横行
            for (int i = 64; i >= 35; i--)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            // 画完第二横行，换行
            Console.WriteLine();
            #region 第二竖行
            for (int i = 65; i < 70; i++)
            {
                Console.WriteLine(DrawStringMap(i));
            }
            #endregion
            #region 第三横行
            for (int i = 70; i < 100; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            // 画完第三横行，换行
            Console.WriteLine();
        }

        /// <summary>
        /// 从画地图方法中抽象出来的一个方法
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static string DrawStringMap(int i)
        {
            string str = "";
            if (playerPos[0] == playerPos[1] && playerPos[0] == i)
            {
                str = "<>";
            }
            else if (playerPos[0] == i)
            {
                //Ａ和Ｂ都是全角，记得将输入法设置成全角
                str = "Ａ";
            }
            else if (playerPos[1] == i)
            {
                str = "Ｂ";
            }
            else
            {
                switch (maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        str = "□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str = "◎";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str = "☆";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        str = "▲";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        str = "卐";
                        break;
                }
            }
            return str;
        }

        /// <summary>
        /// 玩游戏
        /// </summary>
        public static void PlayGame(int playerNumber)
        {
            Random r = new Random();
            int rNumber = r.Next(1, 7);
            Console.WriteLine("玩家{0}按任意键开始掷骰子", playerNames[playerNumber]);
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}掷出了{1}", playerNames[playerNumber], rNumber);
            playerPos[playerNumber] += rNumber;
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}按任意键开始行动", playerNames[playerNumber]);
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}行动完了", playerNames[playerNumber]);
            Console.ReadKey(true);
            //玩家A有可能踩到了玩家B 方块 幸运轮盘 地雷 暂停 时空隧道
            if (playerPos[playerNumber] == playerPos[1 - playerNumber])
            {
                Console.WriteLine("玩家{0}踩到了玩家{1},玩家{2}退6格", playerNames[playerNumber], playerNames[1 - playerNumber], playerNames[1 - playerNumber]);
                playerPos[1 - playerNumber] -= 6;
                Console.ReadKey(true);
            }
            else//踩到了关卡
            {
                switch (maps[playerPos[playerNumber]]) //0 1 2 3 4
                {
                    case 0:
                        Console.WriteLine("玩家{0}踩到了方块，安全。", playerNames[playerNumber]);
                        Console.ReadKey(true);
                        break;
                    case 1:
                        Console.WriteLine("玩家{0}踩到了幸运轮盘，请选择 1--交换位置 2--轰炸对方。", playerNames[playerNumber]);
                        string input = Console.ReadLine();
                        while (true)
                        {
                            if (input == "1")
                            {
                                Console.WriteLine("玩家{0}选择跟玩家{1}交换位置", playerNames[playerNumber], playerNames[1 - playerNumber]);
                                Console.ReadKey(true);
                                int temp = playerPos[playerNumber];
                                playerPos[playerNumber] = playerPos[1 - playerNumber];
                                playerPos[1 - playerNumber] = temp;
                                Console.WriteLine("交换完成！！！按任意键继续游戏！！!");
                                Console.ReadKey(true);
                                break;
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("玩家{0}选择轰炸玩家{1}，玩家{2}退6格", playerNames[playerNumber], playerNames[1 - playerNumber], playerNames[1 - playerNumber]);
                                Console.ReadKey(true);
                                playerPos[1 - playerNumber] -= 6;
                                Console.WriteLine("玩家{0}退了6格", playerNames[1 - playerNumber]);
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("只能输入1或者2   1--交换位置  2--轰炸对方");
                                input = Console.ReadLine();
                            }
                        }
                        Console.ReadKey(true);
                        break;
                    case 2:
                        Console.WriteLine("玩家{0}踩到了地雷吗，退6格。", playerNames[playerNumber]);
                        Console.ReadKey(true);
                        playerPos[playerNumber] -= 6;
                        break;
                    case 3:
                        Console.WriteLine("玩家{0}踩到了暂停，暂停一回合。", playerNames[playerNumber]);
                        Flags[playerNumber] = true;
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.WriteLine("玩家{0}踩到了时空隧道，前进10格。", playerNames[playerNumber]);
                        playerPos[playerNumber] += 10;
                        Console.ReadKey(true);
                        break;
                }
            }

            //清屏之前，先限制一下A和B的坐标
            ChangePos();
            Console.Clear();
            DrawMap();
        }

        /// <summary>
        /// 当玩家坐标发生改变的时候
        /// </summary>
        public static void ChangePos()
        {
            if (playerPos[0] < 0)
            {
                playerPos[0] = 0;
            }
            if (playerPos[0] >= 99)
            {
                playerPos[0] = 99;
            }

            if (playerPos[1] < 0)
            {
                playerPos[1] = 0;
            }
            if (playerPos[1] >= 99)
            {
                playerPos[1] = 99;
            }
        }

        /// <summary>
        /// 胜利时打印
        /// </summary>
        public static void Win()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("胜利！！！！！！！！！！");
            Console.ResetColor();
        }
    }
}
