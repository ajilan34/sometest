using System;
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

            List<BagSthing> B_list = new List<BagSthing>();
            B_list.Add(new BagSthing(1, 0, "神器"));
            B_list.Add(new BagSthing(1, 1, "传说"));
            B_list.Add(new BagSthing(1, 3, "稀有"));
            B_list.Add(new BagSthing(1, 5, "破烂"));
            B_list.Add(new BagSthing(1, 6, "超级破烂"));
            B_list.Add(new BagSthing(2, 0, "未定义"));
            B_list.Add(new BagSthing(0, 1, "次级神药"));
            B_list.Add(new BagSthing(1, 2, "史诗"));
            B_list.Add(new BagSthing(1, 4, "精良"));
            B_list.Add(new BagSthing(0, 0, "神药"));

            Console.WriteLine("怪物列表排序选1，背包列表排序选2,方块移动模式选3");
            string choice = Console.ReadLine();
            if (choice=="1")
            {
                new MonsterSort(M_list);//使用第一种按血量，攻击或防御的方式排列
            }
            else if (choice=="2")
            {
                new BagSthingSort(B_list);
                Console.ReadKey();
            }
            else if (choice == "3")
            {
                ThreadTest threadtest = new ThreadTest();
            }
            
        }
    }
}
