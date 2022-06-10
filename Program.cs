﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace test0605
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Monster> M_list = new List<Monster>();
            M_list.Add(new Monster(100, 10, 10));
            M_list.Add(new Monster(120, 33, 23));
            M_list.Add(new Monster(143, 12, 20));
            M_list.Add(new Monster(11, 12, 55));
            M_list.Add(new Monster(55, 12, 22));
            M_list.Add(new Monster(78, 11, 22));
            M_list.Add(new Monster(90, 56, 30));
            M_list.Add(new Monster(77, 87, 2));
            M_list.Add(new Monster(86, 89, 5));
            M_list.Add(new Monster(321, 98, 100));

            M_list.Sort(delegate(Monster a,Monster b) {
                if (a.health<b.health)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            });

            while (true)
            {
                Console.WriteLine("输入1按血量排序，输入2按攻击排序，输入3按防御排序，输入0倒序列");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        M_list.Sort(delegate (Monster a, Monster b) {
                            if (a.health < b.health)
                            {
                                return -1;
                            }
                            else
                            {
                                return 1;
                            }
                        });
                        break;
                    case 2:
                        M_list.Sort(delegate (Monster a, Monster b) {
                            if (a.atk < b.atk)
                            {
                                return -1;
                            }
                            else
                            {
                                return 1;
                            }
                        });
                        break;
                    case 3:
                        M_list.Sort(delegate (Monster a, Monster b) {
                            if (a.def < b.def)
                            {
                                return -1;
                            }
                            else
                            {
                                return 1;
                            }
                        });
                        break;
                    case 0:
                        List<Monster> temp = new List<Monster>();
                        for (int i = M_list.Count-1; i >=0; i--)
                        {
                            temp.Add(M_list[i]);
                        }
                        M_list = temp;
                        break;
                    default:
                        Console.WriteLine("输入不合法，请重新输入");
                        break;
                }
                Console.WriteLine("当前的怪物列表:");
                for (int i = 0; i < M_list.Count; i++)
                {
                    Console.WriteLine("序号:{0}，血量:{1}，攻击力:{2}，防御力:{3}",i, M_list[i].health, M_list[i].atk, M_list[i].def);
                }
            }
        }
    }
}
