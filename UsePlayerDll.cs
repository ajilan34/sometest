using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace test0605
{
    class UsePlayerDll
    {
        public UsePlayerDll()
        {
            Assembly assembly_player_dll = Assembly.Load("PlayerDll");//拿到数据集
            //要知道里面有什么类，类就是type,那么就要知道里面有什么type
            Type[] types = assembly_player_dll.GetTypes();
            foreach (Type item in types)
            {
                Console.WriteLine(item);
            }
            //然后就可以具体获取一个type
            Type player = assembly_player_dll.GetType("PlayerDll.Player");
            //有了具体的type就可以实例化了
            //实例化可以用type也可以用activator
            object player_instance = Activator.CreateInstance(player);
            
        }
    }
}
