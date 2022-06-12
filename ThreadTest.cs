using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test0605
{
    class ThreadTest
    {
        public ThreadTest()
        {
            int x = 50;
            int y = 15;
            int direction = 3;
            Thread control = new Thread(() =>
            {
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.KeyChar == 'w')
                    {
                        direction = 0;
                    }
                    if (key.KeyChar == 's')
                    {
                        direction = 1;
                    }
                    if (key.KeyChar == 'a')
                    {
                        direction = 2;
                    }
                    if (key.KeyChar == 'd')
                    {
                        direction = 3;
                    }
                }
            });
            control.Start();
            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("■");
                //Console.Write(direction);
                Thread.Sleep(1000);
                switch (direction)
                {
                    case 0:
                        y -= 1;
                        break;
                    case 1:
                        y += 1;
                        break;
                    case 2:
                        x -= 1;
                        break;
                    case 3:
                        x += 1;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
