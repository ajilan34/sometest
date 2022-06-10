using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0605
{
    class List_test2
    {
        List<MyMoney> money_list = new List<MyMoney>();
        public List_test2()
        {
            money_list.Add(new MyMoney(22));
            money_list.Add(new MyMoney(57));
            money_list.Add(new MyMoney(53));
            money_list.Add(new MyMoney(89));
            money_list.Add(new MyMoney(13));
            money_list.Add(new MyMoney(6));
            money_list.Add(new MyMoney(43));
            money_list.Sort();
            foreach ( MyMoney item in money_list)
            {
                Console.WriteLine(item.money);
            }
        }
    }
}
