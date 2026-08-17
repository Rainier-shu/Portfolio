namespace ConsoleApp_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 控制台设置
            Console.CursorVisible = false;

            int w = 80;
            int h = 40;
            //控制台大小
            Console.SetWindowSize(w, h);
            //可操作空间大小(缓冲区)
            Console.SetBufferSize(w, h);
            #endregion

            #region 游戏场景
            int nowScene = 1;
            string overInfo = "";

            while (true)
            {
                switch (nowScene)
                {
                    case 1:
                        Console.Clear();
                        #region 开始场景
                        int nowSelIndex = 0;
                        //设置光标的位置，不用换行不需要使用WriteLine
                        Console.SetCursorPosition(w / 2 - 7, 8);
                        Console.Write("唐老狮营救公主");

                        while (true)
                        {
                            //退出循环的标识：
                            bool isQuitWhile = false;
                            //显示选项
                            Console.SetCursorPosition(w / 2 - 4, 12);
                            //设置后续输出的字体颜色
                            Console.ForegroundColor = nowSelIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("开始游戏");

                            Console.SetCursorPosition(w / 2 - 4, 14);
                            Console.ForegroundColor = nowSelIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("结束游戏");

                            //获取用户输入但不显示出来
                            char input = Console.ReadKey(true).KeyChar;

                            switch (input)
                            {
                                case 'W':
                                case 'w':
                                    --nowSelIndex;
                                    if (nowSelIndex < 0)
                                    {
                                        nowSelIndex = 0;
                                    }
                                    break;
                                case 'S':
                                case 's':
                                    ++nowSelIndex;
                                    if (nowSelIndex > 1)
                                    {
                                        nowSelIndex = 1;
                                    }
                                    break;
                                case 'J':
                                case 'j':
                                    if (nowSelIndex == 0)
                                    {
                                        nowScene = 2;
                                        isQuitWhile = true;
                                    }
                                    else
                                    {
                                        Environment.Exit(0);
                                    }
                                    break;
                            }
                            if (isQuitWhile == true)
                            {
                                break;
                            }
                        }
                        #endregion
                        break;
                    case 2:
                        Console.Clear();
                        #region 游戏核心场景

                        #region 不变的红墙
                        //不变的场景 ■的水平近2格，垂直近1格
                        Console.ForegroundColor = ConsoleColor.Red;
                        int countI = 0;
                        for (int i = 0; i <= w - 2; i += 2)
                        {
                            Console.SetCursorPosition(i, 0);
                            Console.Write("■");
                            Console.SetCursorPosition(i, h - 6);
                            Console.Write("■");
                            Console.SetCursorPosition(i, h - 1);
                            Console.Write("■");
                        }

                        for (int i = 0; i <= h - 1; i++)
                        {
                            Console.SetCursorPosition(0, i);
                            Console.Write("■");
                            Console.SetCursorPosition(w - 2, i);
                            Console.Write("■");
                        }
                        #endregion

                        #region boss属性
                        int bossX = w / 2 - 2;
                        int bossY = h / 2;
                        int bossAtkMin = 7;
                        int bossAtkMax = 13;
                        int bossHp = 100;
                        string bossIcon = "■";
                        ConsoleColor bossColor = ConsoleColor.Green;
                        #endregion

                        #region 玩家属性
                        int playerX = 4;
                        int playerY = 3;
                        int playerAtkMin = 8;
                        int playerAtkMax = 12;
                        int playerHp = 100;
                        string playerIcon = "●";
                        ConsoleColor playerColoer = ConsoleColor.Yellow;
                        #endregion

                        #region 公主属性
                        int princessX = w / 2 - 2; ;
                        int princessY = h / 2 - 12;
                        string princessIcon = "※";
                        ConsoleColor princessColor = ConsoleColor.Blue;
                        #endregion

                        char playerInput;
                        bool isFight = false;
                        bool isOver = false;

                        //玩家操作
                        while (true)
                        {
                            #region boss显示
                            if (bossHp > 0)
                            {
                                Console.SetCursorPosition(bossX, bossY);
                                Console.ForegroundColor = bossColor;
                                Console.Write(bossIcon);
                            }
                            #endregion
                            #region 公主显示
                            else
                            {
                                Console.SetCursorPosition(princessX, princessY);
                                Console.ForegroundColor = princessColor;
                                Console.Write(princessIcon);
                            }
                            #endregion

                            #region 玩家操作
                            Console.SetCursorPosition(playerX, playerY);
                            Console.ForegroundColor = playerColoer;
                            Console.Write(playerIcon);

                            playerInput = Console.ReadKey(true).KeyChar;

                            if (isFight)
                            {
                                #region 开始战斗
                                if (new char[] { 'j', 'J' }.Contains(playerInput))
                                {
                                    if (bossHp <= 0)
                                    {
                                        //boss阵亡
                                        Console.SetCursorPosition(bossX, bossY);
                                        Console.Write(' ');
                                        isFight = false;
                                    }
                                    else if (playerHp <= 0)
                                    {
                                        //玩家阵亡
                                        nowScene = 3;
                                        isFight = false;
                                        overInfo = "惨遭杀害";
                                        break;
                                    }
                                    else
                                    {
                                        //继续战斗
                                        Random r = new Random();
                                        var atk = r.Next(playerAtkMin, playerAtkMax);
                                        bossHp -= atk;
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.SetCursorPosition(2, h - 4);
                                        Console.Write("                                          ");
                                        Console.SetCursorPosition(2, h - 4);
                                        Console.Write($"你对boss造成了{atk}点伤害，boss当前的血量为{bossHp}");

                                        if (bossHp > 0)
                                        {
                                            atk = r.Next(bossAtkMin, bossAtkMax);
                                            playerHp -= atk;
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.SetCursorPosition(2, h - 3);
                                            Console.Write("                                             ");
                                            Console.SetCursorPosition(2, h - 3);

                                            //玩家被打败
                                            if (playerHp <= 0)
                                            {
                                                Console.Write($"boss对你造成了{atk}点伤害，你被打败了，按J键继续");
                                            }
                                            else
                                            {
                                                Console.Write($"boss对你造成了{atk}点伤害，你当前的血量为{playerHp}");
                                            }
                                        }
                                        else
                                        {
                                            //boss被打败
                                            Console.SetCursorPosition(2, h - 5);
                                            Console.Write("                                             ");
                                            Console.SetCursorPosition(2, h - 4);
                                            Console.Write("                                             ");
                                            Console.SetCursorPosition(2, h - 3);
                                            Console.Write("                                             ");
                                            Console.SetCursorPosition(2, h - 5);
                                            Console.Write("恭喜你你击败了boss，快去拯救公主吧");
                                            Console.SetCursorPosition(2, h - 4);
                                            Console.Write("拯救公主按J键继续");
                                        }
                                    }
                                }
                                #endregion
                            }
                            else
                            {
                                #region 玩家移动
                                //清除上一个玩家标识
                                Console.SetCursorPosition(playerX, playerY);
                                Console.Write("  ");

                                switch (playerInput)
                                {
                                    case 'W':
                                    case 'w':
                                        playerY--;
                                        if (playerY < 1)
                                        {
                                            playerY = 1;
                                        }
                                        else if ((playerY == bossY && playerX == bossX && bossHp > 0) || (playerY == princessY && playerX == princessX && bossHp <= 0))
                                        {
                                            playerY++;
                                        }
                                        break;
                                    case 'A':
                                    case 'a':
                                        playerX -= 2;
                                        if (playerX < 2)
                                        {
                                            playerX = 2;
                                        }
                                        else if (playerY == bossY && playerX == bossX && bossHp > 0 || (playerY == princessY && playerX == princessX && bossHp <= 0))
                                        {
                                            playerX += 2;
                                        }
                                        break;
                                    case 'S':
                                    case 's':
                                        playerY++;
                                        if (playerY > h - 7)
                                        {
                                            playerY = h - 7;
                                        }
                                        else if (playerY == bossY && playerX == bossX && bossHp > 0 || (playerY == princessY && playerX == princessX && bossHp <= 0))
                                        {
                                            playerY--;
                                        }
                                        break;
                                    case 'D':
                                    case 'd':
                                        playerX += 2;
                                        if (playerX > w - 4)
                                        {
                                            playerX = w - 4;
                                        }
                                        else if (playerY == bossY && playerX == bossX && bossHp > 0 || (playerY == princessY && playerX == princessX && bossHp <= 0))
                                        {
                                            playerX -= 2;
                                        }
                                        break;
                                    case 'J':
                                    case 'j':
                                        if ((playerX == bossX && playerY == bossY - 1 ||
                                            playerX == bossX && playerY == bossY + 1 ||
                                            playerX == bossX - 2 && playerY == bossY ||
                                            playerX == bossX + 2 && playerY == bossY) && bossHp > 0)
                                        {
                                            isFight = true;
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.SetCursorPosition(2, h - 5);
                                            Console.Write("开始和Boss战斗了，按J键继续");
                                            Console.SetCursorPosition(2, h - 4);
                                            Console.Write($"玩家当前血量为{playerHp}");
                                            Console.SetCursorPosition(2, h - 3);
                                            Console.Write($"boss当前血量为{bossHp}");
                                        }
                                        else if ((playerX == princessX && playerY == princessY - 1 ||
                                            playerX == princessX && playerY == princessY + 1 ||
                                            playerX == princessX - 2 && playerY == princessY ||
                                            playerX == princessX + 2 && playerY == princessY) && bossHp <= 0)
                                        {
                                            nowScene = 3;
                                            isOver = true;
                                            overInfo = "英雄救美";
                                        }
                                        break;
                                }
                                #endregion
                            }
                            #endregion

                            #region 游戏完整结束则跳出到场景选择环节
                            if (isOver == true)
                            {
                                break;
                            }
                            #endregion
                        }
                        #endregion
                        break;
                    case 3:
                        Console.Clear();
                        //显示标题
                        Console.SetCursorPosition(w / 2 - 4, 5);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("GameOver");

                        //显示可变结局
                        Console.SetCursorPosition(w / 2 - 4, 7);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(overInfo);

                        int endSelIndex = 0;
                        bool isEndOver = false;
                        #region 选项
                        while (true)
                        {
                            Console.SetCursorPosition(w / 2 - 6, 9);
                            Console.ForegroundColor = endSelIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("回到开始界面");

                            Console.SetCursorPosition(w / 2 - 4, 11);
                            Console.ForegroundColor = endSelIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");

                            char input = Console.ReadKey(true).KeyChar;

                            switch (input)
                            {
                                case 'W':
                                case 'w':
                                    if (endSelIndex > 0)
                                    {
                                        endSelIndex--;
                                    }
                                    break;
                                case 'S':
                                case 's':
                                    if (endSelIndex < 1)
                                    {
                                        endSelIndex++;
                                    }
                                    break;
                                case 'J':
                                case 'j':
                                    if (endSelIndex == 0)
                                    {
                                        nowScene = 1;
                                        isEndOver = true;
                                    }
                                    else if (endSelIndex == 1)
                                    {
                                        Environment.Exit(0);
                                    }
                                    break;

                            }
                            if (isEndOver)
                            {
                                break;
                            }
                        }
                        #endregion
                        break;
                }
            }
            #endregion
        }
    }
}
